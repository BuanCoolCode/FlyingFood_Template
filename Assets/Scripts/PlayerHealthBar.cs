using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    [SerializeField] public Slider Slider;
    [SerializeField] public PlayerHealth PlayerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Slider.value = (float)PlayerHealth.Healthpoint / (float)PlayerHealth.MaxHealth;
    }
}
