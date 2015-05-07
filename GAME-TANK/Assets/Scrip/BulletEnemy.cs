using UnityEngine;
using System.Collections;

public class BulletEnemy : MonoBehaviour {

    
    void Update()
    {

        if (this.name != "BulletEnemy")
            transform.position += new Vector3(transform.forward.x / 1, 0, transform.forward.z / 1);
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
