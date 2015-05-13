using UnityEngine;
using System.Collections;

public class Protective : MonoBehaviour {

	void OnTriggerEnter (Collider coll) {
        if (coll.gameObject.tag == "Bullet_Type2"
            || coll.gameObject.tag == "Bullet_Type3"
            || coll.gameObject.tag == "Bullet_Type4"
            || coll.gameObject.tag == "Bullet_Type5"
            || coll.gameObject.tag == "Bullet_Type6")
            Destroy(coll.gameObject);
	
	}
}
