using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointHandler : MonoBehaviour
{
    public Transform LastCheckpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Respawn()
    {
        if(LastCheckpoint == null)
        {
            SceneManager.LoadScene("Main");
            return;
        }
        transform.position = LastCheckpoint.position;
        print ("print");
        
    }
}
