using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public string bulletName = null;
    public float moveSpeed=1;
    public float damage=1;
    public float length = 2f;

    public GameObject explosive;
    void Update()
    {

        if (this.name != bulletName)
            transform.position += new Vector3(transform.forward.x * moveSpeed, 0, transform.forward.z * moveSpeed);
        if (gameObject.name == bulletName+"(Clone)")
            Destroy(gameObject, length/moveSpeed);
    }
    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
        Instantiate(explosive, transform.position, Quaternion.Euler(90, 0, 0));        
    }

}
