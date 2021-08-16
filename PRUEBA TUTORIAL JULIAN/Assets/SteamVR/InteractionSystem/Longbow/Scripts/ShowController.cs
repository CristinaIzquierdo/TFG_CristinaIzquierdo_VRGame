using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ShowController : MonoBehaviour
{
    //Variable seleccionable que nos indica si se muestran `true` o no `false` los controllers
    public bool showController = false;
    // Update is called once per frame
    void Update()
    {
      foreach (var hand in Player.instance.hands)
      {
          if(showController)
          {
              hand.ShowController();
              //Sirve para que el modelo de la mano se adapte al modelo del controller y no lo sobrepase
              hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithController);          
          }
          else
          {
              hand.HideController();
              hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithoutController);

          }
      }  
    }
}
