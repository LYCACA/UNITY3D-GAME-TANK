using UnityEngine;
using System.Collections;

public class ItemFenix : MonoBehaviour {

    private GameObject protective;
    public static bool isProtective =false;
    public static bool resetProtective = false;
    public static float missile;
    public void Update()
    {
        if (gameObject.name == "Fenix(Clone)")
            Destroy(gameObject, 10);


    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            isProtective = true;
            resetProtective = true;
        }
    }  
}
