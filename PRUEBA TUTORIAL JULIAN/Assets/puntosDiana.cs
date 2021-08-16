using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntosDiana : MonoBehaviour
{

     public static int Score = 0;
    private TextMeshPro textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
                textMeshPro = GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
                textMeshPro.text = "Puntos: " + Score.ToString();

    }
}
