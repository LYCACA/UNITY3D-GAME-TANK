using UnityEngine;
using System.Collections;

public class MoveScrip : MonoBehaviour {

	//public GameObject Tank;
	public float speed = 10f;
    private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		//Tank = GameObject.Find ("T-90a");		
       rigidbody = GetComponent<Rigidbody>();
	}
	void Update()
	{
        
        //Move and rotation theo 2d
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                Quaternion.Euler(0, 270, 0),
                                                5 * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 250 && transform.rotation.eulerAngles.y < 290 ||
                transform.rotation.eulerAngles.y > 215 && transform.rotation.eulerAngles.y < 235 ||
                transform.rotation.eulerAngles.y > 305 && transform.rotation.eulerAngles.y < 325)
                        rigidbody.MovePosition(rigidbody.position - Vector3.right * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                   Quaternion.Euler(0, 90, 0),
                                                   5 * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 60 && transform.rotation.eulerAngles.y < 120 ||
                transform.rotation.eulerAngles.y > 35 && transform.rotation.eulerAngles.y < 55 ||
                transform.rotation.eulerAngles.y > 125 && transform.rotation.eulerAngles.y < 145)
                     rigidbody.MovePosition(rigidbody.position - Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.Euler(0, 0, 0),
                                                    5 * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 350 || transform.rotation.eulerAngles.y < 10 ||
                    transform.rotation.eulerAngles.y > 305 && transform.rotation.eulerAngles.y < 325 ||
                    transform.rotation.eulerAngles.y > 35 && transform.rotation.eulerAngles.y < 55)
                rigidbody.MovePosition(rigidbody.position - Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                   Quaternion.Euler(0, 180, 0),
                                                   5 * Time.deltaTime);
            if (transform.rotation.eulerAngles.y > 160 && transform.rotation.eulerAngles.y < 200 ||
                transform.rotation.eulerAngles.y > 125 && transform.rotation.eulerAngles.y < 145 ||
               transform.rotation.eulerAngles.y > 215 && transform.rotation.eulerAngles.y < 235)
                rigidbody.MovePosition(rigidbody.position - Vector3.forward * speed * Time.deltaTime);
        }

       // Camera.main.transform.position = new Vector3(this.transform.position.x, 35, this.transform.position.z);

       
        //Move and rotation theo FPS
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.rotation = Quaternion.Slerp(transform.rotation,
        //                                        Quaternion.Euler(0, transform.rotation.eulerAngles.y - 10, 0),
        //                                        5 * Time.deltaTime);
           

        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.rotation = Quaternion.Slerp(transform.rotation,
        //                                           Quaternion.Euler(0, transform.rotation.eulerAngles.y + 10, 0),
        //                                           5 * Time.deltaTime);
          
        //}
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    this.transform.Translate (Vector3.back * speed * Time.deltaTime);
        //}
        /* */
         
    }
}
