using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    public float turnSpeed = 50f;

	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	}
}
