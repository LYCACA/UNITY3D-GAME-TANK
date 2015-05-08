using UnityEngine;
using System.Collections;

public class HPEnemy : MonoBehaviour {

    public float hp = 100;
    private float damage = 10;
    public string nameTagBullet = "";
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == nameTagBullet)
        {
            hp = hp - damage;
            print(hp);
        }
        if (hp <= 0)
            DestroyObject(this.gameObject);
    }
}
