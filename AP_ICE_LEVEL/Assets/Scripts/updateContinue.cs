using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateContinue : MonoBehaviour
{
    // Start is called before the first frame update
    public void seeCheck()
    {
        int level = PlayerPrefs.GetInt("Level");
        int cont = PlayerPrefs.GetInt("ContinueLevel");
        if (level.Equals(cont))
        {
            cont = cont + 1;
            PlayerPrefs.SetInt("ContinueLevel", cont);
            PlayerPrefs.SetInt("Level", cont);
            PlayerPrefs.SetInt("canPlay" + cont.ToString(), 1);
            PlayerPrefs.Save();
        }
    }
}
