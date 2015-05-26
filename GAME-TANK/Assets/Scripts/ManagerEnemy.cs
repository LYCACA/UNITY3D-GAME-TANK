using UnityEngine;
using System.Collections;

public class ManagerEnemy : MonoBehaviour {
    private bool isCollider = false;
    public GameObject tankPlayer;
    void OnTriggerEnter(Collider collider)
    {       
        if (collider.gameObject.name == tankPlayer.name && isCollider == false)
        {

            isCollider = true;
            Manager _controller = GameObject.Find("Controller").GetComponent<Manager>();
            for (int i = 0; i < 4; i++)
            {
                GameObject _enemy = _controller.Enemy[Random.Range(0, 12)];
                Vector3 _posSpawnPoint = new Vector3(
                    transform.position.x + Random.Range(-4, 5)*5,
                    0 + 1f,
                    transform.position.z + Random.Range(-4, 5)*5);
                Instantiate(_enemy, _posSpawnPoint, transform.rotation);
               
            }

        }

    }
}
