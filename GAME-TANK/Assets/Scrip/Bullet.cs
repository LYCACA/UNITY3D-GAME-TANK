using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    void Update()
    {

        if (this.name != "Bullet")
            transform.position += new Vector3(transform.forward.x / 1, 0, transform.forward.z / 1);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
            DestroyObject(col.gameObject);
        Destroy(this.gameObject);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
