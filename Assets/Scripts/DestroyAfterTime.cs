using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
