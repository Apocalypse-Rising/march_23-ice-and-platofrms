using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoControl : MonoBehaviour
{
    float startTime;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        currentTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime - startTime > 12)
        {
            SceneManager.LoadScene("Main Menu");
        }
        currentTime = Time.time;
    }
}
