using UnityEngine;
using System.Collections;

public class HPPlayer : MonoBehaviour {

    public float hp = 100;
    public string nameTagBullet1 = null;
    public float damage1 = 0;
    public string nameTagBullet2 = null;
    public float damage2 = 0;
    public string nameTagBullet3 = null;
    public float damage3 = 0;
    public string nameTagBullet4 = null;
    public float damage4 = 0;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == nameTagBullet1)
        {
            hp = hp - damage1;
        }
        if (col.gameObject.tag == nameTagBullet2)
        {
            hp = hp - damage2;
        }
        if (col.gameObject.tag == nameTagBullet3)
        {
            hp = hp - damage3;
        }
        if (col.gameObject.tag == nameTagBullet4)
        {
            hp = hp - damage4;
        }
        if (hp <= 0)
            DestroyObject(this.gameObject);
        print(hp);
    }
}
