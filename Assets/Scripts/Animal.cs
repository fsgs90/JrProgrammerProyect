using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Animal : MonoBehaviour
{
    // Examples of encapsulation
    private string animalName = "Animal";
    public string AnimalName
    {
        get { return animalName; }  
        set { animalName = value; }
    }

    int animalSpeed = 5;
    public int AnimalSpeed
    {
        get { return animalSpeed; }
        set { animalSpeed = value; }
    }

    int animalHealth = 5;
    public int AnimalHealth
    {
        get { return animalHealth; }
        set { animalHealth = value; }
    }

    public Text nameText;
    public Text healthText;
    public Text speedText;

    // Example of abstraction - Updating the text displyed with information inside a function called UpdateDisplay
    public virtual void UpdateDisplay()
    {
        nameText.text = ("Name: " + animalName);
        healthText.text = "Health: " + animalHealth.ToString();
        speedText.text = "Speed: " + animalSpeed.ToString();
    }
}
