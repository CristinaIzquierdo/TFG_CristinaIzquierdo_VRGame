using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarCanvas : MonoBehaviour
{

public GameObject cambiarMalo;
public GameObject canvasBueno;

   public void btn_changeCanvas()
   {
       cambiarMalo.gameObject.SetActive(false);
       canvasBueno.gameObject.SetActive(true);

   }
}
