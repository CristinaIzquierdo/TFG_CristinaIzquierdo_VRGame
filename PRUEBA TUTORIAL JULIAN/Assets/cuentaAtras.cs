using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cuentaAtras : MonoBehaviour
{

    // public static int Tiempo = 20;
    // private TextMeshProUGUI textMeshPro;


    // // Start is called before the first frame update
    // void Start()
    // {
    //     textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if(Tiempo > 0) {
    //        Tiempo = Tiempo - 1;
    //        Debug.Log(Tiempo);
    //        textMeshPro.text = "Tiempo: " + Tiempo.ToString();

    //     }
    // }

    private static int minutes;
    private static int seconds;

    //private int m,s;

    private static int m = 100;
    private static int s = 10;
 private TextMeshProUGUI textMeshPro;
    void Start()
    {
        textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
         writeTimer(m,s);
    }

     void Update()
    {
                 updateTimer();

    }

    public void startTimer(){
        writeTimer(m,s);
        //invo("updateTimer", 1f);
        updateTimer();


    } 

     public void stopTimer(){
        
        
    } 

     private void updateTimer(){
         s--;
         if(s < 0){
             //endGame  
         } else {
             m--;
             s = 59;
         }

         writeTimer(m,s);
         // Inkove("updateTimer", 1f);

        
    } 

    private void writeTimer(int m, int s){

        if (s<10){
             textMeshPro.text = m.ToString()+ ":0" +s.ToString();

        } else {
            textMeshPro.text = m.ToString()+ ":" +s.ToString();


        }


    }

}
