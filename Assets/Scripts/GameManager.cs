using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KinematicCharacterController;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] Watermelon WatermelonBoss;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Respawn(Vector3 spawnPosition)
    {
        KinematicCharacterMotor.instance.SetPosition(spawnPosition);
    }
    public void Death()
    {
        WatermelonBoss.IsDying = true;
    }
}
