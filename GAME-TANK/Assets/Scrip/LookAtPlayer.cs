using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {

    private Transform target;
    private GameObject gameObj;
    void Start()
    {
        gameObj = GameObject.Find("Target");
    }
    void Update()
    {
        transform.LookAt(gameObj.transform);
    }
}
