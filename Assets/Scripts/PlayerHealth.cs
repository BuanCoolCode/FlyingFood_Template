using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using KinematicCharacterController;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int Healthpoint = 10;
    private bool IsDying = false;
    public int MaxHealth;
    [SerializeField] GameObject Deathscreen;
    [SerializeField] KinematicCharacterMotor exampleCharacterController;
    [SerializeField] AudioSource MusicSource;
    [SerializeField] CheckpointHandler checkpointHandler;
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = Healthpoint;
        //Healthpoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Healthpoint <= 0 && !IsDying)
        {
            IsDying = true;
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        Deathscreen.SetActive(true);
        exampleCharacterController.enabled = false;
        yield return new WaitForSeconds(4);
        checkpointHandler.Respawn();
        yield return new WaitForSeconds(0.5f);
        exampleCharacterController.enabled = true;
    }
     void OnTriggerEnter(Collider other)
    {
        if (IsDying)
        {
            return;
        }
        if (other.gameObject.tag == "Death")
        {
            Healthpoint = 0;
        }

    }
    void FixedUpdate()
    {
        if (IsDying)
        {
            MusicSource.volume = MusicSource.volume-0.003f;
        }   
    }

}
