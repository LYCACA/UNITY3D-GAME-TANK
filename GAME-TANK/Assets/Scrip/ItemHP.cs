using UnityEngine;
using System.Collections;

public class ItemHP : MonoBehaviour {
    public float hp=5;
    public void Update()
    {
        if (gameObject.name == "Oil_Barrell(Clone)")
            Destroy(gameObject, 10);
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            if ((Info.hp + hp) <= Info.hpMax)
                Info.hp = Info.hp + hp;
            else
                Info.hp = Info.hpMax;
        }
        
    }      
}
