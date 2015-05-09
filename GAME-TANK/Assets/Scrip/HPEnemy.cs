using UnityEngine;
using System.Collections;

public class HPEnemy : MonoBehaviour {

    public float hp = 100;
    private float damage = 10;
    public string nameTagBullet = "";

    private GameObject item;

    public string nameItem1 = "Oil_Barrell";
    void Start()
    {
        item = GameObject.Find(nameItem1);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == nameTagBullet)
        {
            hp = hp - damage;
            print(hp);
        }
        if (hp <= 0)
        {
            DestroyObject(this.gameObject);
            int rd=Random.Range(1, 5);
            if(rd==1){
                Vector3 pos = new Vector3(transform.position.x, 1f, transform.position.z);
                Instantiate(item, pos, transform.rotation);
            }
        }
    }
}
