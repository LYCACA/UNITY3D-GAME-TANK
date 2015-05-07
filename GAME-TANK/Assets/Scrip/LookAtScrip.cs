using UnityEngine;
using System.Collections;

public class LookAtScrip : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        Vector3 inputPos = Input.mousePosition;
        inputPos.z = Camera.main.farClipPlane;

        inputPos = Camera.main.ScreenToWorldPoint(inputPos);
        inputPos.y = 1.49f;
		transform.LookAt(inputPos);
	}
}
