using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : MonoBehaviour
{
    int Healthpoint = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        print(Healthpoint);
        Healthpoint = Healthpoint - 1;
        if(Healthpoint <= 0)
        {
            gameObject.Destroy();
        }
    }
}
