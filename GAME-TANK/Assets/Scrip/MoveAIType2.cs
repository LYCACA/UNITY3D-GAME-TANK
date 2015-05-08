using UnityEngine;
using System.Collections;

public class MoveAIType2 : MonoBehaviour {

    public float fireRate = 5F;
    private float nextFire = 0.0F;

    public float moveSpeed = 10f;
    public float turnSpeed = 5f;

    private byte changeDirection = 0;
    void Update()
    {
        if (changeDirection == 1)
        {
            
        }
        else if (changeDirection == 2)
        {
            
        }
        else if (changeDirection == 3)
        {
            
        }
        else if (changeDirection == 4)
        {
            
        }
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            changeDirection++;
            if (changeDirection == 4)
            {
                changeDirection = 1;
            }
        }
    }
}
