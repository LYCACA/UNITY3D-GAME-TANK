using UnityEngine;
using System.Collections;

public class SightMouse : MonoBehaviour {

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 pos = hit.point;
            pos.y = 2f;
            transform.position = pos;
        }       
    }
    void OnTriggerEnter(Collider coll)
    {

    }
}
