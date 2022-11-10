using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBall : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
            FindObjectOfType<Difficulty>().ONUI();
            FindObjectOfType<Timer>().StopTimer();
            FindObjectOfType<MoveBack>().StopGame();
        FindObjectOfType<PlayerPrefsController>().At();
    }

 
}
