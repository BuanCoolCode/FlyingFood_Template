using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] GameObject TextPrompt;
    private bool PlayerIsInRange = false;
    private bool Activated = false;
    [SerializeField] Material ActiveMaterial;
    private GameObject PlayerInRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerIsInRange && Input.GetKeyDown(KeyCode.E))
     {
        Activate();
     }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TextPrompt.SetActive(true);
            PlayerIsInRange = true;
            PlayerInRange = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TextPrompt.SetActive(false);
            PlayerIsInRange = false;
            PlayerInRange = null;
        }
    }
    void Activate()
    {
        if (Activated) return;
        print ("activate");
        Activated = true;
        GetComponent < MeshRenderer >().material = ActiveMaterial;
        PlayerInRange.GetComponent < CheckpointHandler >().LastCheckpoint = transform;
    }
}
