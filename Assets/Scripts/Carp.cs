using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carp : Animal
{
    int carpHealth = 5;
    int carpSpeed = 5;
    public GameObject arowana;
    public GameObject frog;

    private void Start()
    {
        // This line of code disables the outline showed on click. 
        this.GetComponent<Outline>().enabled = false;
    }

    // Detct mouse click and update text
    private void OnMouseDown()
    {
        Debug.Log("CLICKED CARP");
        AnimalName = "Carp";
        AnimalHealth = carpHealth;
        AnimalSpeed = carpSpeed;
        UpdateDisplay();
        this.GetComponent<Outline>().enabled = true;
        arowana.GetComponent<Outline>().enabled = false;
        frog.GetComponent<Outline>().enabled = false;
    }

    // Example of polymorphism and abstraction by overriding a function with data specific to the Carp class
    public override void UpdateDisplay()
    {
        nameText.text = ("Name: " + AnimalName);
        healthText.text = "Health: " + AnimalHealth.ToString();
        speedText.text = "Speed: " + AnimalSpeed.ToString();
    }
}

