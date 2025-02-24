using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WMStatue : MonoBehaviour
{
[SerializeField] GameObject ChallengeText;
private bool PlayerIsInRange = false;
[SerializeField] string SceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
     if (PlayerIsInRange && Input.GetKeyDown(KeyCode.E))
     {
        print("pressedE");
        SceneManager.LoadScene(SceneToLoad);
     }
    }
    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ChallengeText.SetActive(true);
            PlayerIsInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ChallengeText.SetActive(false);
            PlayerIsInRange = false;
        }
    }
}