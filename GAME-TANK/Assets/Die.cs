using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {
    public float hp = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {

            hp = hp - 1;
            print(hp);
            if (hp <= 0)
                DestroyObject(this.gameObject);
        }

    }
}
