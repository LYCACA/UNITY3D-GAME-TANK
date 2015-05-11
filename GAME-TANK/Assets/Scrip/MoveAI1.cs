using UnityEngine;
using System.Collections;

public class MoveAI1 : MonoBehaviour {
    public float moveSpeed = 10f;
    public float turnSpeed = 1f;
    private GameObject tank;

    public float rangeAct = 100;

    public float fireRate = 5F;
    private float nextFire = 0.0F;

    private int rd;

   // public int direction=0;
    void Start()
    {
        tank = GameObject.Find("Target");        
    }
	void Update () {

        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            rd = Random.Range(0, 4);
        }

        float rangeActX = Mathf.Abs(tank.transform.position.x - transform.position.x);
        float rangeActZ = Mathf.Abs(tank.transform.position.z - transform.position.z);
        if (rangeActX < rangeAct && rangeActZ < rangeAct)
            if (gameObject.tag == "Enemy")
            {  
                if (rd==0)
                {
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), turnSpeed * Time.deltaTime);
                    if (transform.rotation.eulerAngles.y > 330 || transform.rotation.eulerAngles.y < 30)
                        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                }
                if (rd==1)
                {
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), turnSpeed * Time.deltaTime);
                    if (transform.rotation.eulerAngles.y > 60 && transform.rotation.eulerAngles.y < 120)
                        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

                }
                if (rd==2)
                {
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 180, 0), turnSpeed * Time.deltaTime);
                    if (transform.rotation.eulerAngles.y > 150 && transform.rotation.eulerAngles.y < 210)
                        transform.Translate(-Vector3.back * moveSpeed * Time.deltaTime);
                }
                if (rd==3)
                {
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 270, 0), turnSpeed * Time.deltaTime);
                    if (transform.rotation.eulerAngles.y > 240 && transform.rotation.eulerAngles.y < 300)
                        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                }
            }
	}
}
