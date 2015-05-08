using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

    public GameObject bullet;
    public GameObject posBul;

    public string nameBullet="";

    public float fireRate = 1F;
    private float nextFire = 0.0F;
    // Use this for initialization
    void Start()
    {
        bullet = GameObject.Find(nameBullet);
        posBul = GameObject.Find("PosGun");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))  
            Shoot();
        
    }
    public void Shoot()
    {
        Vector3 posBullet = new Vector3(posBul.transform.position.x, posBul.transform.position.y, posBul.transform.position.z);
        Instantiate(bullet, posBullet, posBul.transform.rotation);
    }
}
