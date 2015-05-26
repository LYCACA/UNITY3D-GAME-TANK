using UnityEngine;
using System.Collections;

public class MoveAI1 : MonoBehaviour {
    private Rigidbody rigidbody;
    private float moveSpeed = 300000;//Độ mạnh lực đẩy
    public float turnSpeed = 10; //Tốc độ quay

    public float fireRate = 3F;
    private float nextFire = 0.0F;

    public bool reverse = false;//Đảo ngược di chuyển
    private int isReverse = 1;

    private int rd = 0;
    public bool random = true;
    public bool octagonal = false;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        if (reverse == true)
            isReverse = -1;
        else
            isReverse = 1;
    }
    void Update()
    {
        Move();
    }
    void Move()
    {

        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            /*
            *Random huong 
            */
            if (random == true)
                rd = Random.Range(1, 10);
            /*
            * Di chuyen luc bat giac
            */
            else if (octagonal == true)
            {
                if (rd == 8)
                    rd = 1;
                else
                    rd++;
            }

        }
        if (rd == 2)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 45, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 35 && transform.rotation.eulerAngles.y < 55)
            {
                rigidbody.AddForce(isReverse * Vector3.forward * moveSpeed / 1.3f * Time.deltaTime);
                rigidbody.AddForce(isReverse * Vector3.right * moveSpeed / 1.3f * Time.deltaTime);
            }
        }
        else if (rd == 4)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 135, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 125 && transform.rotation.eulerAngles.y < 145)
            {
                rigidbody.AddForce(isReverse * Vector3.right * moveSpeed / 1.3f * Time.deltaTime);
                rigidbody.AddForce(isReverse * Vector3.back * moveSpeed / 1.3f * Time.deltaTime);
            }
        }
        else if (rd == 6)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 225, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 215 && transform.rotation.eulerAngles.y < 235)
            {
                rigidbody.AddForce(isReverse * Vector3.back * moveSpeed / 1.3f * Time.deltaTime);
                rigidbody.AddForce(isReverse * Vector3.left * moveSpeed / 1.3f * Time.deltaTime);
            }
        }
        else if (rd == 8)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 315, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 305 && transform.rotation.eulerAngles.y < 325)
            {
                rigidbody.AddForce(isReverse * Vector3.left * moveSpeed / 1.3f * Time.deltaTime);
                rigidbody.AddForce(isReverse * Vector3.forward * moveSpeed / 1.3f * Time.deltaTime);
            }
        }
        else if (rd == 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 350 || transform.rotation.eulerAngles.y < 10)
                rigidbody.AddForce(isReverse * Vector3.forward * moveSpeed * Time.deltaTime);
        }


        else if (rd == 3)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 80 && transform.rotation.eulerAngles.y < 100)
                rigidbody.AddForce(isReverse * Vector3.right * moveSpeed * Time.deltaTime);
        }

        else if (rd == 5)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 180, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 170 && transform.rotation.eulerAngles.y < 190)
                rigidbody.AddForce(isReverse * Vector3.back * moveSpeed * Time.deltaTime);
        }

        else if (rd == 7)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 270, 0), turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 260 && transform.rotation.eulerAngles.y < 280)
                rigidbody.AddForce(isReverse * Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
}
