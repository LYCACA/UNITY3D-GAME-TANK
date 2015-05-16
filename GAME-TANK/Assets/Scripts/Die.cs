using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

    void OnDestroy()
    {
        StopGame.ISWIN = true;
    }
}
