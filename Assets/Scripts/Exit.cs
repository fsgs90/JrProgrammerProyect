using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Game is exiting");
        //Just to make sure its working
        Application.Quit();
    }
}
