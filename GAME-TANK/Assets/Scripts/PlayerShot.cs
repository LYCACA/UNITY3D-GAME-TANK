using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour
{

    public GameObject bullet;
    public GameObject missile;
    private GameObject posBul;
    private AudioSource tank;
    private GameObject bulletEnemy;

    private float fireRate = 0.2F;
    private float nextFire = 0.0F;

    private bool isShooting = false;
    // Use this for initialization
    void Start()
    {
        tank = GameObject.Find("Tank").GetComponent<AudioSource>();
        posBul = GameObject.Find("PosGun");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            if (isShooting)
            {
                bulletEnemy = bullet;
                Shoot();
            }                
        }
        if (Input.GetButton("Fire1"))
        {
            isShooting = true;
        }
        else
            isShooting = false;
        if (Input.GetButtonDown("Fire1"))
        {
            bulletEnemy = bullet;
            Shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (ItemMissile.missile > 0)
            {
                ItemMissile.missile--;
                bulletEnemy = missile;
                Shoot();
            }
        }
    }
    public void Shoot()
    {
        tank.Play();
        Vector3 posBullet = new Vector3(posBul.transform.position.x, posBul.transform.position.y, posBul.transform.position.z);
        Instantiate(bulletEnemy, posBullet, posBul.transform.rotation);
    }
}
