using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField]
    Slider slider;



    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = Common.maxHealth;
        slider.value = Common.healthLeft;
    }

    // Update is called once per frame
    void Update()
    {
		slider.value = Common.healthLeft;
	}
}
