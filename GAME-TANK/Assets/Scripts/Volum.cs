using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Volum : MonoBehaviour {

    public static float VOLUM = 1;
    public Slider slider;

    private AudioSource audiosource;
	// Use this for initialization
	void Start () {
        audiosource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        audiosource.volume = slider.value;
        VOLUM = slider.value;
	}
}
