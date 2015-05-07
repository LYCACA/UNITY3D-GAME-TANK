using UnityEngine;
using System.Collections;

public class CameraMoveScrip : MonoBehaviour {
	void Update () {
        Camera.main.transform.position = new Vector3(this.transform.position.x, 30f, this.transform.position.z);
     
	}
}
