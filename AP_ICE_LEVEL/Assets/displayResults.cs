using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayResults : MonoBehaviour
{
    public Text time;
    public Text combo;
    public Text kills;
    // Start is called before the first frame update
    void Start()
    {
        int level = PlayerPrefs.GetInt("Level");
        time.text += PlayerPrefs.GetFloat("Time").ToString();
        combo.text += PlayerPrefs.GetInt("Combo").ToString();
        kills.text += PlayerPrefs.GetInt("Kills").ToString();
        float bestTime = PlayerPrefs.GetFloat("bestTime" + level.ToString());
        int bestCombo = PlayerPrefs.GetInt("bestCombo" + level.ToString());
        int bestKills = PlayerPrefs.GetInt("bestKills" + level.ToString());
        PlayerPrefs.SetInt("canPlay" + level.ToString(), 1);
        if (bestTime > PlayerPrefs.GetFloat("Time"))
        {
            time.text += "\t\t\tNew Record!";
            PlayerPrefs.SetFloat("bestTime" + level.ToString(), PlayerPrefs.GetFloat("Time"));
        }
        if (bestCombo < PlayerPrefs.GetInt("Combo"))
        {
            combo.text += "\t\t\tNew Record!";
            PlayerPrefs.SetInt("bestCombo" + level.ToString(), PlayerPrefs.GetInt("Combo"));
        }
        if (bestKills < PlayerPrefs.GetInt("Kills"))
        {
            kills.text += "\t\t\tNew Record!";
            PlayerPrefs.SetInt("bestKills" + level.ToString(), PlayerPrefs.GetInt("Kills"));
        }
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
