using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.name == "Dead(Clone)")
            Destroy(gameObject, 2);	
	}
}
