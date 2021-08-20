using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class dianaScore : MonoBehaviour
{
    public static int Score = 0;
    private TextMeshPro textMeshPro;
   
    void Start() 
    {
        textMeshPro = GetComponent<TextMeshPro>();
       // score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        //textMeshPro.text = "Score: " + Counter; 
        textMeshPro.text = "Puntos: " + Score.ToString();
    }
}
