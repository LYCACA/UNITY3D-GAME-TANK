using UnityEngine;
using System.Collections;

public class ItemMissile : MonoBehaviour {

    public static float missile;
    public void Update()
    {
        if (gameObject.name == "Missile_MBDA_Meteor(Clone)")
            Destroy(gameObject, 10);
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            missile = +5;
        }
    }  
}
