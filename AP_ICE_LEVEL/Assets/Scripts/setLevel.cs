using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void setPref()
    {
        PlayerPrefs.SetInt("Level", 1);
        PlayerPrefs.SetInt("Kills", 0);
        PlayerPrefs.SetInt("Combo", 0);
        PlayerPrefs.SetInt("Continued?", 1);
        PlayerPrefs.SetInt("ContinueLevel", 1);
        for (int i = 1; i <= 6; i++  )
        {
            PlayerPrefs.SetFloat("bestTime" + i.ToString(), 1000000);
            PlayerPrefs.SetInt("bestCombo" + i.ToString(), 0);
            PlayerPrefs.SetInt("bestKills" + i.ToString(), 0);
            PlayerPrefs.SetInt("canPlay" + i.ToString(), 0);
        }
    }
}

