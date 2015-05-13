using UnityEngine;
using System.Collections;

public class MessageExit : MonoBehaviour {

	public void OnclickYes ()
    {
        Application.Quit();
    }
    public void OnclickNo()
    {
        Destroy(gameObject);
    }
}
