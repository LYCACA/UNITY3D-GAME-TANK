using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float hp = 100;
    private float damage;
    
    private GameObject item1;
    private GameObject item2;
    private GameObject item3;

    public string nameItem1 = "Oil_Barrell";
    public string nameItem2 = "Missile_MBDA_Meteor";
    public string nameItem3 = "Fenix";

    public float score=5;
    void Start()
    {
        item1 = GameObject.Find(nameItem1);
        item2 = GameObject.Find(nameItem2);
        item3 = GameObject.Find(nameItem3);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == Info.nameBullet)
        {
            if (Info.nameBullet == "Bullet_Type1")
                damage = 5;
            else if (Info.nameBullet == "missele")
                damage = 10;
            hp = hp - damage;
        }
        if (hp <= 0)
        {
            DestroyObject(this.gameObject);
            
            //item
            int rd=Random.Range(1, 3);
            if(rd == 1){
                Vector3 pos = new Vector3(transform.position.x, 1f, transform.position.z);
                Instantiate(item1, pos, transform.rotation);
            }
            else if (rd == 2)
            {
                Vector3 pos = new Vector3(transform.position.x, 1f, transform.position.z);
                Instantiate(item2, pos, transform.rotation);
            }
            else if (rd == 3)
            {
                Vector3 pos = new Vector3(transform.position.x, 1f, transform.position.z);
                Instantiate(item3, pos, transform.rotation);
            }
            //score
            Info.score = +score;

        }
    }
}
