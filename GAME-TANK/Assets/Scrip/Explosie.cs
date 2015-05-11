using UnityEngine;
using System.Collections;

public class Explosie : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.name == "Explosie(Clone)")
            Destroy(gameObject, 1);
	}
}
