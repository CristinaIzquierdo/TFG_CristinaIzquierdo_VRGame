using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargarAvatar1 : MonoBehaviour
{
    public GameObject primerCanvas;
    public GameObject segundoCanvas;

   public void btn_changeCanvas()
   {
       primerCanvas.gameObject.SetActive(false);
       segundoCanvas.gameObject.SetActive(true);

   }
}
