using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public string bulletName = "";

    public float moveSpeed=1;

    void Update()
    {

        if (this.name != bulletName)
            transform.position += new Vector3(transform.forward.x * moveSpeed, 0, transform.forward.z * moveSpeed);
    }
    void OnCollisionEnter(Collision col)
    {        
        Destroy(gameObject);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
