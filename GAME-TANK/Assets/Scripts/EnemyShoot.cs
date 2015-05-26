using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour
{

    public GameObject bulletEnemy;
    private Transform posBulEnemy;

    public float range = 32;

    private float fireRate = 2F;
    private float nextFire = 0.0F;

    private GameObject tank;
    // Use this for initialization
    void Start()
    {
        Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.gameObject.name == "PosBullEnemy")
            {
                posBulEnemy = t;
            }
        }
        tank = GameObject.Find("Target");   
    }

    // Update is called once per frame
    void Update()
    {
        float rangeX = Mathf.Abs(tank.transform.position.x - transform.position.x);
        float rangeZ = Mathf.Abs(tank.transform.position.z - transform.position.z);
        if (rangeX < range && rangeZ < range)
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Shoot();
            }
    }
    public void Shoot()
    {
        Instantiate(bulletEnemy, posBulEnemy.position, posBulEnemy.rotation);
    }
}
