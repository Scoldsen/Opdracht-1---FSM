using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public GameObject Enemy;

    //Dit is een StateMachine:
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("Enemy in");
            Enemy.GetComponent<PatrollingState>().enabled = false;
            Enemy.GetComponent<ChasingState>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Enemy out");

            Enemy.GetComponent<ChasingState>().enabled = false;
            Enemy.GetComponent<PatrollingState>().enabled = true;
        }
    }
}
