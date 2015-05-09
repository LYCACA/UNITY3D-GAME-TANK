using UnityEngine;
using System.Collections;

public class ItemHP : MonoBehaviour {
	
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Info.hp = Info.hp + 50;
        }           
    }       
}
