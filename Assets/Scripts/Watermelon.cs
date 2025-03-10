using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : MonoBehaviour
{
    private bool IsDying = false;
    [SerializeField]int Healthpoint = 5;
    [SerializeField] GameObject watermelon;
    [SerializeField] AudioSource MusicSource;
    [SerializeField] Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (IsDying)
        {
            MusicSource.volume = MusicSource.volume-0.003f;
        }   
    }
    void OnCollisionEnter(Collision other)
    {
        if (IsDying)
        {
            return;
        }
        print(Healthpoint);
        Healthpoint = Healthpoint - 1;
        if(Healthpoint <= 0)
        {
            StartCoroutine(Death());
        }
    }
    IEnumerator Death()
    {
        IsDying = true;
        rigidBody.constraints = RigidbodyConstraints.None;
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}