using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    public void LoadNextScene()
    {
        Debug.Log("Loading next scene");
        SceneManager.LoadScene("AnimalPicker", LoadSceneMode.Additive);
    }
}
