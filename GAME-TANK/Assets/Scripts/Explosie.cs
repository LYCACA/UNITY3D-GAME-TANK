using UnityEngine;
using System.Collections;

public class Explosie : MonoBehaviour {
	void Update () {
        if (gameObject.name == "Explosie(Clone)")
            Destroy(gameObject, 1);
	}
}
