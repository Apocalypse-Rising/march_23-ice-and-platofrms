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
        time.text += PlayerPrefs.GetFloat("Time").ToString();
        combo.text += PlayerPrefs.GetInt("Combo").ToString();
        kills.text += PlayerPrefs.GetInt("Kills").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
