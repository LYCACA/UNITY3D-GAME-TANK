using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour
{

    private GameObject bullet;
    private GameObject posBul;
    private AudioSource tank;

    public string nameBulletDefault=null;
    // Use this for initialization
    void Start()
    {
        tank = GameObject.Find("Tank").GetComponent<AudioSource>();
        posBul = GameObject.Find("PosGun");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            bullet = GameObject.Find(nameBulletDefault);
            Shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (ItemMissile.missile > 0)
            {
                ItemMissile.missile--;
                bullet = GameObject.Find("Missile");
                Shoot();
            }
            
            
        }
    }
    public void Shoot()
    {
        tank.Play();
        Vector3 posBullet = new Vector3(posBul.transform.position.x, posBul.transform.position.y, posBul.transform.position.z);
        Instantiate(bullet, posBullet, posBul.transform.rotation);
    }
}
