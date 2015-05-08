using UnityEngine;
using System.Collections;

public class ShotEnemy : MonoBehaviour {

    private GameObject bulletEnemy;
    private Transform posBulEnemy;

    public string butlletName = null;

    private float fireRate = 1F;
    private float nextFire = 0.0F;
    // Use this for initialization
    void Start()
    {
        bulletEnemy = GameObject.Find(butlletName);
        Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.gameObject.name == "PosBullEnemy")
            {
                posBulEnemy = t;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

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
