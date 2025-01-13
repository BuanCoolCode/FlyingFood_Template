using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] public AudioSource audiochange;
    private bool IsStarting = false;
    public void ButtonPressed()
    {
        StartCoroutine("WaitAndChange");
        IsStarting = true;
    }
    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Main");
    }
    void FixedUpdate()
    {
        if (IsStarting == true)
        {
            audiochange.volume = audiochange.volume-0.005f;
        }
    }
}
