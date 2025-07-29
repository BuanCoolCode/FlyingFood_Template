using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : MonoBehaviour
{
    public bool IsDying = false;
    [SerializeField] public int Healthpoint = 5;
    [SerializeField] public int jumpHeight = 5;
    [SerializeField] GameObject watermelon;
    [SerializeField] GameObject landingFX;
    [SerializeField] AudioSource MusicSource;
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] UnityEngine.AI.NavMeshAgent Agent;
    [SerializeField] Transform PlayerTransform;
    public int MaxHealth;
    // Start is called before the first frame update


    void Start()
    {
        MaxHealth = Healthpoint;
        InvokeRepeating(nameof(Jump),5,5);
    }
    private void Jump()
    {
        GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        GetComponent<Rigidbody>().velocity = new Vector3(0, jumpHeight, 0);
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
        Instantiate(landingFX,transform.position,Quaternion.identity);
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