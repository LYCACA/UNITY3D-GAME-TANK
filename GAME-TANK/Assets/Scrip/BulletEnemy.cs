using UnityEngine;
using System.Collections;

public class BulletEnemy : MonoBehaviour {

    public float hp = 1;
    void Update()
    {

        if (this.name != "BulletEnemy")
            transform.position += new Vector3(transform.forward.x / 1, 0, transform.forward.z / 1);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
          
            hp=hp-1;
            print(hp);
            if (hp <= 0)
                DestroyObject(col.gameObject);
        }
        Destroy(gameObject);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
