using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public float hp = 100;
    private float damage;

    private bool die = false;

    private GameObject dead;
    
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;


    private int rd;
    private bool isItem = true;

    public float score=5;
    private bool isScore = true;

    private GameObject hpEnemy;
    private GameObject hPMax;

    public GameObject explosion;
    void Start()
    { 
        dead = GameObject.Find("Dead");
        

    }
    void Update()
    {
        /*
        *HP enemy
        */

        
    }
    void OnCollisionEnter(Collision col)
    {
        rd = Random.Range(1, 10);
        Vector3 pos = new Vector3(transform.position.x, 1f, transform.position.z);

        /*
         * Damage
         */
        if (col.gameObject.tag == "Bullet_Type1")
        {           
            damage = 5;           
            hp = hp - damage;            
        }
        else if (col.gameObject.tag == "Missile")
        {
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
            Destroy(Instantiate(explosion, transform.position, transform.rotation),3);
           
            if(isScore==true)
                Info.score +=score;
            isScore = false;
        }
    }
}
