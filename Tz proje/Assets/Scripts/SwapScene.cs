using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour
{
    private int Attempt;
    public Text attempttext;
    private bool frs = true;

    private void Start()
    {
        
    }

    public void FirstSave(int Atm)
    {
        Attempt = Atm;
        FindObjectOfType<PlayerPrefsController>().SaveAttempt(Attempt);
    }
  
    public void Attemp(int At)
    {
        attempttext.text = string.Format("{0}", At);
        FindObjectOfType<PlayerPrefsController>().SaveAttempt(At);
    }

    public void Swap(int SceneID)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneID);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
