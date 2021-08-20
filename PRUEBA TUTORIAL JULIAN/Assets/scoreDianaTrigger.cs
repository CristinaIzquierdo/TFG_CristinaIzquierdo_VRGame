using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreDianaTrigger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
      
       if(collision.transform.name == "targetRojo")
      {
       
          dianaScore.Score += 1;
          //collision.gameObject.transform.children = gameObject.transform;

          //permite que cuando la bola choque con puntosCentro, se quede pegada
          GetComponent<Rigidbody>().isKinematic = true;

      } else 


      
       if(collision.transform.name == "targetVerde")
      {
       
          dianaScore.Score += 3;
          //collision.gameObject.transform.children = gameObject.transform;

          //permite que cuando la bola choque con puntosCentro, se quede pegada
          GetComponent<Rigidbody>().isKinematic = true;
 
      } else 

        if(collision.transform.name == "targetBlanco")
      {
       
          dianaScore.Score += 0;
          //collision.gameObject.transform.children = gameObject.transform;

          //permite que cuando la bola choque con puntosCentro, se quede pegada
          GetComponent<Rigidbody>().isKinematic = true;
 
      } 
      else 

        if(collision.transform.name == "targetAmarillo")
      {
       
          dianaScore.Score += 2;
          //collision.gameObject.transform.children = gameObject.transform;

          //permite que cuando la bola choque con puntosCentro, se quede pegada
          GetComponent<Rigidbody>().isKinematic = true;
 
      } 



      
    }
}
