using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour
{

    private GameObject bullet;
    private GameObject posBul;

    public string nameBulletDefault=null;
    // Use this for initialization
    void Start()
    {
        
        posBul = GameObject.Find("PosGun");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if (ItemMissile.missile > 0)
            {
                ItemMissile.missile--;
                Info.nameBullet = "Missile";
            }
            else
                Info.nameBullet = nameBulletDefault;
            bullet = GameObject.Find(Info.nameBullet);
            Shoot();
        }
    }
    public void Shoot()
    {
        Vector3 posBullet = new Vector3(posBul.transform.position.x, posBul.transform.position.y, posBul.transform.position.z);
        Instantiate(bullet, posBullet, posBul.transform.rotation);
    }
}
