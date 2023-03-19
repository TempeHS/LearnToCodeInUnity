using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DoWhileandWhileScript : MonoBehaviour
{

    private int GameOver = 1;

    public TextMeshProUGUI OutputObject;

    public GameObject[] ColoredSpheres;
    private Color[] ColorArray = { Color.red, Color.blue, Color.green, Color.yellow};

    void Update ()
    {

        if (Input.GetKeyDown("space"))
        {
            GameOver = 0;
        } else {
            GameOver = 1;
        }

        while (GameOver < 1)
        {
            GameOver++;
            ChangeColours();
        } 
    }

    void ChangeColours ()
    {
        for (int SphereIndex = 0; SphereIndex < ColoredSpheres.Length; SphereIndex++)
        {
            int RandomColor = Random.Range(0, ColoredSpheres.Length +1);
            ColoredSpheres[SphereIndex].GetComponent<MeshRenderer>().material.color = ColorArray[RandomColor];
        }
    }

}