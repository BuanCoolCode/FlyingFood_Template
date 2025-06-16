using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : MonoBehaviour
{
    public bool IsDying = false;
    [SerializeField] public int Healthpoint = 5;
    [SerializeField] GameObject watermelon;
    [SerializeField] AudioSource MusicSource;
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] UnityEngine.AI.NavMeshAgent Agent;
    [SerializeField] Transform PlayerTransform;
    public int MaxHealth;
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = Healthpoint;
    }

    // Update is called once per frame
     void Update()
    {
        Agent.destination = PlayerTransform.position; 
    }
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
        if (other.gameObject.tag != "Projectiles")
        {
            return;
        }
        Healthpoint = Healthpoint - 1;
        if(Healthpoint <= 0)
        {
            StartCoroutine(Death());
        }
    }
    IEnumerator Death()
    {
        IsDying = true;
        //rigidBody.constraints = RigidbodyConstraints.None;
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}