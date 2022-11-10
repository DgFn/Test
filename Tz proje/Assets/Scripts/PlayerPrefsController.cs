using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class PlayerPrefsController : MonoBehaviour
{
    private Save sv = new Save();
    private Saves svs = new Saves();


    public int Scene;
    public int Attem;
    public bool fr;
    private void Start()
    {
        if(Scene == 1)
        {
            sv = JsonUtility.FromJson<Save>(PlayerPrefs.GetString("Save"));
            FindObjectOfType<MoveBack>().ChooseSpeed(sv.Speed);
            svs = JsonUtility.FromJson<Saves>(PlayerPrefs.GetString("Saves"));
            Debug.Log("da4");
            Attem = svs.Attempt;
            Debug.Log("da3");
            if (Attem == 0)
            {
                Debug.Log("da1");
            }
            else
            {
                Debug.Log("da2");
                svs = JsonUtility.FromJson<Saves>(PlayerPrefs.GetString("Saves"));
                Attem = svs.Attempt;
            }
             //сделать отдельную функцию
        }
        svs = JsonUtility.FromJson<Saves>(PlayerPrefs.GetString("Saves"));
        Attem = svs.Attempt;
        if (Scene == 0 & Attem == 0)
        {
            Debug.Log("da");
            FindObjectOfType<SwapScene>().FirstSave(0);
      
        }
        else
        {

            return;
          
        }
       

    }

    public void At()
    {
        svs = JsonUtility.FromJson<Saves>(PlayerPrefs.GetString("Saves"));
        FindObjectOfType<SwapScene>().Attemp(svs.Attempt);

    }


    public void SaveSpeed(float Spees)
    {
        if (!PlayerPrefs.HasKey("Save"))
        {
            sv.Speed = Spees;
            Attem = svs.Attempt;
            PlayerPrefs.SetString("Save", JsonUtility.ToJson(sv));
        }
        else
        {
            sv.Speed = Spees;
            Attem = svs.Attempt;
            PlayerPrefs.SetString("Save", JsonUtility.ToJson(sv));
        }
    }

    public void SaveAttempt(int At)
    {
        if (!PlayerPrefs.HasKey("Saves"))
        {
            svs.Attempt = At + 1;
            PlayerPrefs.SetString("Saves", JsonUtility.ToJson(svs));
        }
        else
        {
            svs.Attempt = At + 1;
            PlayerPrefs.SetString("Saves", JsonUtility.ToJson(svs));
        }
    }

    [Serializable]
    public class Save
    {
        public float Speed;
        
    }

    [Serializable]
    public class Saves
    {
        public int Attempt;
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("Save", JsonUtility.ToJson(sv));
        PlayerPrefs.SetString("Saves", JsonUtility.ToJson(svs));
    }


}
