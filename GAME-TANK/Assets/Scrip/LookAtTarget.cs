using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour {

    public Transform target;
    public GameObject gameObj;
    void Start()
    {
        gameObj = GameObject.Find("Target");
    }
    void Update()
    {
        transform.LookAt(gameObj.transform);
    }
}
