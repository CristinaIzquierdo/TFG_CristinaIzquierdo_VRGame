using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntuacionTotalJuegos : MonoBehaviour
{
    public static int puntuacionTotal = 0;
    private TextMeshPro textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
    }

    


    // Update is called once per frame
    void Update()
    {
       puntuacionTotal = scoreBaloncesto.Score + bolosScore.Score + dianaScore.Score;
       textMeshPro.text = puntuacionTotal.ToString() + " pts.";

    }
}
