using UnityEngine;
using System.Collections;

public class MoveAI3 : MonoBehaviour {

    public float rangeMax = 35;
    public float rangeMin = 15;
    public float rangeStop = 30;
    public float moveSpeed=10;
    private GameObject tank;


	// Use this for initialization
	void Start () {
        tank = GameObject.Find("Target");
	}
	
	// Update is called once per frame
	void Update () {
	    float rangeX = Mathf.Abs(tank.transform.position.x - transform.position.x);
        float rangeZ = Mathf.Abs(tank.transform.position.z - transform.position.z);       
        if (rangeMin > rangeX && rangeMin > rangeZ)
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        else if (rangeX < rangeStop && rangeZ < rangeStop)
        { }
        else if (rangeX < rangeMax && rangeZ < rangeMax)
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x,0.0f,transform.position.z);
	}
}
