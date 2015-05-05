using UnityEngine;
using System.Collections;

public class BulletEnemy_TET001 : MonoBehaviour {

    void Update()
    {

        if (this.name != "BulletEnemy")
            transform.position += new Vector3(transform.forward.x / 8, 0, transform.forward.z / 8);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "VatCanMem")
            DestroyObject(col.gameObject);
        Destroy(gameObject);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
