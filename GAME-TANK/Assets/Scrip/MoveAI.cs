using UnityEngine;
using System.Collections;

public class MoveAI : MonoBehaviour {
    public float moveSpeed = 10f;
    public float turnSpeed = 1f;
    public bool contact = false;
    public GameObject tank;
    public float distance = 100;
    public float distanceX;
    public float distanceZ;

    public float fireRate = 5F;
    private float nextFire = 0.0F;

    public int rd;

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
        
        distanceX = Mathf.Abs(tank.transform.position.x - transform.position.x);
        distanceZ = Mathf.Abs(tank.transform.position.z - transform.position.z);
        if (distanceX < distance && distanceZ < distance)
            if (gameObject.tag == "Enemy")
            {
                /*if (transform.rotation.eulerAngles.y > 1 && contact == false)
                {                    
                        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);                   
                }
                else
                    transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
                */      
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
                        transform.Translate(Vector3.fwd * moveSpeed * Time.deltaTime);
                }
            }
        /*
         */
        transform.position = new Vector3(transform.position.x, 1f, transform.position.z);
        /*
        */
	}
    void OnCollisionEnter()
    {
        contact = true;
    }
    void OnCollisionExit()
    {
        contact = false;
    }
}
