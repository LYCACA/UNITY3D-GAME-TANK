using UnityEngine;
using System.Collections;

public class RandomPosition : MonoBehaviour {

    public Vector3 newPosition = Random.insideUnitCircle * 5;
    void Start()
    {
        transform.position = new Vector3(transform.position.x, 1f, transform.position.z);
    }
}
