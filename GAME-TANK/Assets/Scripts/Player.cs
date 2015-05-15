using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public string nameTagBullet2 = "Bullet_Type";
    public float damage2 = 0;
    public string nameTagBullet3 = "Bullet_Type";
    public float damage3 = 0;
    public string nameTagBullet4 = "Bullet_Type";
    public float damage4 = 0;
    public string nameTagBullet5 = "Bullet_Type";
    public float damage5 = 0;
    public string nameTagBullet6 = "Bullet_Type";
    public float damage6 = 0;

    public GameObject smoke;
    private Vector3 posSmoke;

    private float fireRate = 20F;
    private float nextFire = 0.0F;

    void Start()
    {
        smoke = GameObject.Find("Smoke");
        posSmoke = smoke.transform.position;
    }
    void Update()
    {
        if (Info.hp > 0 && Info.hp < 50)
            smoke.transform.position = transform.position;
        else
            smoke.transform.position = posSmoke;
       // print(Info.hp);

        /*
         *Protective 
         */
        if (ItemFenix.isProtective == true)
        {
            GameObject.Find("Protective").transform.position = transform.position;
            
        }
        if (ItemFenix.resetProtective == true)
        {
            nextFire = Time.time + fireRate;
            ItemFenix.resetProtective = false;
        }        
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject.Find("Protective").transform.position = new Vector3(-177f, 20f, -131f);
            ItemFenix.isProtective = false;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == nameTagBullet2)
        {
            Info.hp = Info.hp - damage2;
        }
        if (col.gameObject.tag == nameTagBullet3)
        {
            Info.hp = Info.hp - damage3;
        }
        if (col.gameObject.tag == nameTagBullet4)
        {
            Info.hp = Info.hp - damage4;
        }
        if (col.gameObject.tag == nameTagBullet5)
        {
            Info.hp = Info.hp - damage5;
        }
        if (col.gameObject.tag == nameTagBullet6)
        {
            Info.hp = Info.hp - damage6;
        }

        if (Info.hp <= 0)
            DestroyObject(this.gameObject);        
    }
}
