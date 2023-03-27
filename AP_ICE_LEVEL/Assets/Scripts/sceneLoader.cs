using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string sceneName)
    {
        if (sceneName.Equals("Level "))
        {
            int lev = PlayerPrefs.GetInt("Level");
            int continueLev = PlayerPrefs.GetInt("ContinueLevel");
            if (continueLev == lev)
            {
                PlayerPrefs.SetInt("ContinueLevel", continueLev + 1);
            }
            lev += 1;
            PlayerPrefs.SetInt("Level", lev);
            PlayerPrefs.Save();
            SceneManager.LoadScene(sceneName + lev.ToString());
        } else if (sceneName.Equals("Game Over"))
        {
            int lev = PlayerPrefs.GetInt("Level");
            SceneManager.LoadScene("Level " + lev.ToString());
        }
        else if (sceneName.Equals("Continue"))
        {
            int level = PlayerPrefs.GetInt("ContinueLevel");
            SceneManager.LoadScene("Level " + level.ToString());
        }
        else if (sceneName.Contains("Select"))
        {
            int len = sceneName.Length;
            int level = Int32.Parse( sceneName.Substring(len - 1));
            PlayerPrefs.SetInt("Level", level);
            PlayerPrefs.Save();
            SceneManager.LoadScene("Level " + sceneName.Substring(len - 1));
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }
}