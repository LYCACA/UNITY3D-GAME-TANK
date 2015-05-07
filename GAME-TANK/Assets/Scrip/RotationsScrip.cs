using UnityEngine;
using System.Collections;

public class RotationsScrip : MonoBehaviour {
    private float turnSpeed = 10f;
    // Use this for initialization
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), turnSpeed * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), turnSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 180, 0), turnSpeed * Time.deltaTime);          
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 270, 0), turnSpeed * Time.deltaTime);
        }
    }

}
