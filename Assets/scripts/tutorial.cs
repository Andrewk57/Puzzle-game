using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public GameObject[] popups;
    private int popUpIndex;
    private void Update()
    {
        for (int i = 0; i < popups.Length; i++)
        {
            if (i==popUpIndex)
            {
                popups[i].SetActive(true);
            }
            else
            {
                popups[i].SetActive(false);
            }
        }
        if(popUpIndex == 0)
        {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 1)
        {
            if(buttonHandleR.onButton==true)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 2)
        {
            if(metalButton.onButtonMetal==true)
            {
                popUpIndex++;
            }
        }
        
    }
}
