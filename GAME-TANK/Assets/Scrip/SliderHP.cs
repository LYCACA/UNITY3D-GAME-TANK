using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderHP : MonoBehaviour {

    public Slider slider;
	void Update () {
        slider.value = Info.hp / 100;
	}
}
