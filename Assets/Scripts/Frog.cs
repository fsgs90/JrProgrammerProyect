using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : Animal
{

    int frogHealth = 7;
    int frogSpeed = 3;
    public GameObject carp;
    public GameObject arowana;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Outline>().enabled = false;
    }

    // Detect click and update display
    private void OnMouseDown()
    {
        Debug.Log("CLICKED FROG");
        AnimalName = "Frog";
        AnimalHealth = frogHealth;
        AnimalSpeed = frogSpeed;
        UpdateDisplay();
        this.GetComponent<Outline>().enabled = true;
        arowana.GetComponent<Outline>().enabled = false;
        carp.GetComponent<Outline>().enabled = false;
    }


    // Example of polymorphism and abstraction by overriding a function with data specific to the Frog class
    public override void UpdateDisplay()
    {
        nameText.text = ("Name: " + AnimalName);
        healthText.text = "Health: " + AnimalHealth.ToString();
        speedText.text = "Speed: " + AnimalSpeed.ToString();
    }
}

