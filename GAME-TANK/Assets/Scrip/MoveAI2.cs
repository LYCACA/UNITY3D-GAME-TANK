using UnityEngine;
using System.Collections;

public class MoveAI2 : MonoBehaviour {

    public float fireRate = 5F;
    private float nextFire = 0.0F;

    public float moveSpeed = 10f;
    public float rangeAct = 50;
    private GameObject tank;

    private bool changeDirection = true;
    void Start()
    {
        tank = GameObject.Find("Target");
    }
	void Update () {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            if (changeDirection == true)
            {
                changeDirection = false;
            }

            else
            {
                changeDirection = true;
            }
        }
        float rangeActX = Mathf.Abs(tank.transform.position.x - transform.position.x);
        float rangeActZ = Mathf.Abs(tank.transform.position.z - transform.position.z);
        if (rangeActX < rangeAct && rangeActZ < rangeAct)
            if (changeDirection == true)
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
            }
	}
}
