using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WMStatue : MonoBehaviour
{
    [SerializeField] Transform PlayerTransform;
    [SerializeField] Transform SpawnerTransform;
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
        PlayerTransform.position = new Vector3(0,1000,0);
        print("Hello");
    }
}
