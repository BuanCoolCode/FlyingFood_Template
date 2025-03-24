using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    [SerializeField] public Watermelon WaterMelon;
    [SerializeField] public Slider Slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Slider.value = (float)WaterMelon.Healthpoint / (float)WaterMelon.MaxHealth;
    }   
}