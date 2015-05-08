using UnityEngine;
using System.Collections;

public class HP : MonoBehaviour {

    public float hp = 100;
    public float dame = 10;
    public string nameTagBullet = "";
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == nameTagBullet)
        {
            hp = hp-dame;
            print(hp);
            if (hp <= 0)
                DestroyObject(this.gameObject);
        }

    }
}
