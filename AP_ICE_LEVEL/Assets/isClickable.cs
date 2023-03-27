using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class isClickable : MonoBehaviour
{
    public List<Button> buttonList;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("lvlButton");
        for (int i = 0; i < buttons.Length; i++)
        {
            buttonList.Add(buttons[i].GetComponent<Button>());
        }
        for (int j = 1; j <= buttons.Length; j++ )
        {
            int check = PlayerPrefs.GetInt("canPlay" + j.ToString());
            if (check == 1)
            {
                buttonList[j-1].interactable = true;
            }
            else
            {
                buttonList[j - 1].interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
