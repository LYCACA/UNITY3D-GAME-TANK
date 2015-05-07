using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

    public GameObject bulletEnemy;
    public GameObject posBulEnemy;

    public float fireRate = 1F;
    private float nextFire = 0.0F;
    // Use this for initialization
    void Start()
    {
        bulletEnemy = GameObject.Find("Bullet");
        posBulEnemy = GameObject.Find("PosGun");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))  
            Shoot();
        
    }
    public void Shoot()
    {
        Vector3 posBullet = new Vector3(posBulEnemy.transform.position.x, posBulEnemy.transform.position.y, posBulEnemy.transform.position.z);
        Instantiate(bulletEnemy, posBullet, posBulEnemy.transform.rotation);
    }
}
