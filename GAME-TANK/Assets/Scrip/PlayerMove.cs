using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{

    private GameObject Tank;
    public string nameTank = "Tank";
    public float moveSpeed = 20f;
    void Start()
    {
        Tank = GameObject.Find(nameTank);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (transform.rotation.eulerAngles.y > 330 || transform.rotation.eulerAngles.y < 30)
                Tank.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (transform.rotation.eulerAngles.y > 60 && transform.rotation.eulerAngles.y < 120)
                Tank.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (transform.rotation.eulerAngles.y > 150 && transform.rotation.eulerAngles.y < 210)
                Tank.transform.Translate(-Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.eulerAngles.y > 240 && transform.rotation.eulerAngles.y < 300)
                Tank.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        Vector3 inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        inputPos.y = 0;
    }
}
