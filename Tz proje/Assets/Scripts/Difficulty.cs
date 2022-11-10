using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    private float Sper;
    public Text Timertext;
    public GameObject Easy, Medium, Hard, Restart, Main, EndTime, Attempt, Difficult;

    private void Start()
    {
        Easy.SetActive(false);
        Medium.SetActive(false);
        Hard.SetActive(false);
        Main.SetActive(false);
        Timertext = GetComponent<Text>();
        Timertext.enabled = false;
        Restart.SetActive(false);
        EndTime.SetActive(false);
        Attempt.SetActive(false);
        Difficult.SetActive(false);
    }

    public void ONUI()
    {
        Timertext = GetComponent<Text>();
        Timertext.enabled = true;
        Restart.SetActive(true);
        Main.SetActive(true);
        EndTime.SetActive(true);
        Attempt.SetActive(true);
        Difficult.SetActive(true);
    }
    public void Takedifficulty(float Speed)
    {
        Sper = Speed;
        FindObjectOfType<PlayerPrefsController>().SaveSpeed(Sper);
    }

    public void OnButton()
    {
        Easy.SetActive(true);
        Medium.SetActive(true);
        Hard.SetActive(true);
        Restart.SetActive(false);
        Difficult.SetActive(false);
        
    }

    public void OffButton()
    {
        Easy.SetActive(false);
        Medium.SetActive(false);
        Hard.SetActive(false);
        Restart.SetActive(true);
        Difficult.SetActive(true);
    }

}
