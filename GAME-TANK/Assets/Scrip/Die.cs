using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {
    public float hp = 10;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {

            hp--;
            print(hp);
            if (hp <= 0)
                DestroyObject(this.gameObject);
        }

    }
}
