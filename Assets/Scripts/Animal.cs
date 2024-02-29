using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Animal : MonoBehaviour
{
    string animalName = "Animal";
    int animalSpeed = 5;
    int animalHealth = 5;

    public Text nameText;
    public Text healthText;
    public Text speedText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("The left mouse button was pressed");
            UpdateDisplay();
        } 
    }

    public virtual void UpdateDisplay()
    {
        nameText.text = ("Name: " + animalName);
        healthText.text = "Health: 5";
        speedText.text = "Speed: 5";
    }
}
