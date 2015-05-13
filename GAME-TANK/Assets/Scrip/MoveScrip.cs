using UnityEngine;
using System.Collections;

public class MoveScrip : MonoBehaviour {

	public float speed = 10f;
    private Rigidbody rigidbody;
	void Start () {
       rigidbody = GetComponent<Rigidbody>();
	}
	void Update()
	{
       
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                Quaternion.Euler(0, 270, 0),
                                                5 * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 250 && transform.rotation.eulerAngles.y < 290 ||
                transform.rotation.eulerAngles.y > 215 && transform.rotation.eulerAngles.y < 235 ||
                transform.rotation.eulerAngles.y > 305 && transform.rotation.eulerAngles.y < 325)
                        rigidbody.MovePosition(rigidbody.position - Vector3.right * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                   Quaternion.Euler(0, 90, 0),
                                                   5 * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 60 && transform.rotation.eulerAngles.y < 120 ||
                transform.rotation.eulerAngles.y > 35 && transform.rotation.eulerAngles.y < 55 ||
                transform.rotation.eulerAngles.y > 125 && transform.rotation.eulerAngles.y < 145)
                     rigidbody.MovePosition(rigidbody.position - Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.Euler(0, 0, 0),
                                                    5 * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 350 || transform.rotation.eulerAngles.y < 10 ||
                    transform.rotation.eulerAngles.y > 305 && transform.rotation.eulerAngles.y < 325 ||
                    transform.rotation.eulerAngles.y > 35 && transform.rotation.eulerAngles.y < 55)
                rigidbody.MovePosition(rigidbody.position - Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                   Quaternion.Euler(0, 180, 0),
                                                   5 * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 160 && transform.rotation.eulerAngles.y < 200 ||
                transform.rotation.eulerAngles.y > 125 && transform.rotation.eulerAngles.y < 145 ||
               transform.rotation.eulerAngles.y > 215 && transform.rotation.eulerAngles.y < 235)
                rigidbody.MovePosition(rigidbody.position - Vector3.forward * speed * Time.deltaTime);
        }     
    }
}
