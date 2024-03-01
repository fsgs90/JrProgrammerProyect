using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arowana : Animal
{
    int arowanaHealth = 3;
    int arowanaSpeed = 7;
    public GameObject frog;
    public GameObject carp;

    private void Start()
    {
        this.GetComponent<Outline>().enabled = false;
    }
    private void OnMouseDown()
    {
        Debug.Log("CLICKED AROWANA");
        AnimalName = "Arowana";
        AnimalHealth = arowanaHealth;
        AnimalSpeed = arowanaSpeed;
        UpdateDisplay();
        this.GetComponent<Outline>().enabled = true;
        carp.GetComponent<Outline>().enabled = false;
        frog.GetComponent<Outline>().enabled = false;
    }

    // Example of polymorphism and abstraction by overriding a function with data specific to the Arowana class
    public override void UpdateDisplay()
    {
        nameText.text = ("Name: " + AnimalName);
        healthText.text = "Health: " + AnimalHealth.ToString();
        speedText.text = "Speed: " + AnimalSpeed.ToString();
    }
}

