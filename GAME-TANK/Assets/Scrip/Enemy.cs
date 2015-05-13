using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public float hp = 100;
    private float damage;

    private bool die = false;

    private GameObject dead;
    
    private GameObject item1;
    private GameObject item2;
    private GameObject item3;

    public string nameItem1 = "Oil_Barrell";
    public string nameItem2 = "Missile_MBDA_Meteor";
    public string nameItem3 = "Fenix";

    private int rd;
    private bool isItem = true;

    public float score=5;
    private bool isScore = true;

    private GameObject hpEnemy;
    private GameObject hPMax;
    void Start()
    { 
        dead = GameObject.Find("Dead");
        /*
         * Random item
         */
        rd = Random.Range(3, 3);
        item1 = GameObject.Find(nameItem1);
        item2 = GameObject.Find(nameItem2);
        item3 = GameObject.Find(nameItem3);
        

    }
    void Update()
    {
        /*
        *HP enemy
        */

        
    }
    void OnCollisionEnter(Collision col)
    {
        Vector3 pos = new Vector3(transform.position.x, 1f, transform.position.z);

        /*
         * Damage
         */
        if (col.gameObject.tag == Info.nameBullet)
        {
            if (Info.nameBullet == "Bullet_Type1")
                damage = 5;
            else if (Info.nameBullet == "Missile")
                damage = 20;
            hp = hp - damage;
            
        }

        /*
         * Cardboard dead
         */
        if (col.gameObject.tag == "Player" )
            if (gameObject.name == "ArmyPilot")
            {                
                Destroy(gameObject,2);
                die = true;
                Instantiate(dead, pos, Quaternion.Euler(0, 0, 0));
            }


        if (hp <= 0 || die == true)
        {
            DestroyObject(this.gameObject);
            
            /*
             * item
             */
            if (rd == 1 && isItem==true)
            {
                Instantiate(item1, pos, transform.rotation);
            }
            else if (rd == 2 && isItem == true)
            {
                Instantiate(item2, pos, transform.rotation);
            }
            else if (rd == 3 && isItem == true)
            {
                Instantiate(item3, pos, transform.rotation);
            }
            isItem =false;

            /*
             * score
             */
           
            if(isScore==true)
                Info.score +=score;
            isScore = false;
            
        }
    }
}
