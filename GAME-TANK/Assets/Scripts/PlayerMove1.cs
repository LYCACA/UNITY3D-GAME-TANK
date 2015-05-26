using UnityEngine;
using System.Collections;

public class PlayerMove1 : MonoBehaviour
{
    
    private Rigidbody rigidbody;
    public float moveSpeed = 1000000;
    public float turnSpeed=10;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {        
        Move();

    }
    void Move()
    {
        


        if ((Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 45, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 35 && transform.rotation.eulerAngles.y < 55)
            {
                rigidbody.AddForce(Vector3.forward * moveSpeed / 1.3f * Time.deltaTime);
                rigidbody.AddForce(Vector3.right * moveSpeed / 1.3f * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow)))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 135, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 125 && transform.rotation.eulerAngles.y < 145)
            {
                rigidbody.AddForce(Vector3.right * moveSpeed / 1.3f * Time.deltaTime);
                rigidbody.AddForce(Vector3.back * moveSpeed / 1.3f * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 225, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 215 && transform.rotation.eulerAngles.y < 235)
            {
                rigidbody.AddForce(Vector3.back * moveSpeed / 1.3f * Time.deltaTime);
                rigidbody.AddForce(Vector3.left * moveSpeed / 1.3f * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow)))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 315, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 305 && transform.rotation.eulerAngles.y < 325)
            {
                rigidbody.AddForce(Vector3.left * moveSpeed / 1.3f * Time.deltaTime);
                rigidbody.AddForce(Vector3.forward * moveSpeed / 1.3f * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 350 || transform.rotation.eulerAngles.y < 10)
                rigidbody.AddForce(Vector3.forward * moveSpeed * Time.deltaTime);
        }


        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 80 && transform.rotation.eulerAngles.y < 100)
                rigidbody.AddForce(Vector3.right * moveSpeed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 180, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 170 && transform.rotation.eulerAngles.y < 190)
                rigidbody.AddForce(Vector3.back * moveSpeed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 270, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 260 && transform.rotation.eulerAngles.y < 280)
                rigidbody.AddForce(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
}
