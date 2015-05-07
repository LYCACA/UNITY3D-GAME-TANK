using UnityEngine;
using System.Collections;

public class MoveScrip : MonoBehaviour {

    public GameObject Tank;
    public float moveSpeed = 20f;
    void Start()
    {
        Tank = GameObject.Find("Tank");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.rotation.eulerAngles.y > 330 || transform.rotation.eulerAngles.y < 30)
                Tank.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.rotation.eulerAngles.y > 60 && transform.rotation.eulerAngles.y < 120)
                Tank.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.rotation.eulerAngles.y > 150 && transform.rotation.eulerAngles.y < 210)
                Tank.transform.Translate(-Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.rotation.eulerAngles.y > 240 && transform.rotation.eulerAngles.y < 300)
                Tank.transform.Translate(Vector3.fwd * moveSpeed * Time.deltaTime);
        }
        Vector3 inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        inputPos.y = 0;
    }
}
