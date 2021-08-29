using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cuentaAtras : MonoBehaviour
{

     public static float Tiempo = 180;
     private TextMeshProUGUI textMeshPro;
     public GameObject teleportPointVerPuntos = null;
     public Vector3 destination = new Vector3(-11,0,-15); //assign it from inspector or code

   //  float currentTime = 0f;
   //  float startingTime = 50f;


    // // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
       // currentTime = startingTime
    }

    // // Update is called once per frame
    void Update()
    {
        if(Tiempo > 0) {
           Tiempo -= 1 * Time.deltaTime;
         //  Debug.Log(Tiempo);
           textMeshPro.text = "Tiempo: " + Tiempo.ToString();

        } else {
           // Debug.Log("Tiempo terminado, teletransportando player!");
            //Move object
            textMeshPro.text = "Tiempo: 0";
            teleportPointVerPuntos.transform.position = destination;

        }
    }



   

}
