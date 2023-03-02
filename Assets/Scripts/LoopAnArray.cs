using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LoopAnArray : MonoBehaviour
{

    private string[] MyAnimals = { "cat", "dog", "snake" };

    public TextMeshProUGUI OutputObject;

    public GameObject[] ColoredSpheres;
    private Color[] ColorArray = { Color.red, Color.blue, Color.green, Color.yellow};

    void Update ()
    {
        for (int SphereIndex = 0; SphereIndex < ColoredSpheres.Length; SphereIndex++)
        {
            int RandomColor = Random.Range(0, ColoredSpheres.Length);
            ColoredSpheres[SphereIndex].GetComponent<MeshRenderer>().material.color = ColorArray[RandomColor];
        }
    }
    
    
    
    
    /* void Update()
    {
        string OutputString = "";

        for (int ArrayIndex = 0; ArrayIndex < MyAnimals.Length; ArrayIndex++)
        {
            OutputString = OutputString + " " + MyAnimals[ArrayIndex];
        } 

        OutputObject.text = OutputString;

    } */

}