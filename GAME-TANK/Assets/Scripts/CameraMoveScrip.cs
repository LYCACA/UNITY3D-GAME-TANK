using UnityEngine;
using System.Collections;

public class CameraMoveScrip : MonoBehaviour {

    public float hightCam=25f;
	void Update () {
        Camera.main.transform.position = new Vector3(this.transform.position.x, hightCam, this.transform.position.z);
     
	}
}
