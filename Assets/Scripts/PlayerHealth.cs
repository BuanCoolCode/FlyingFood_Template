using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int Healthpoint = 10;
    public int MaxHealth;
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = Healthpoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
