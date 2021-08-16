using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreDianaTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
      
       if(collision.transform.name == "PuntosBlanco")
      {
        Debug.Log("Estoy en puntosBlanco ");
          puntosDiana.Score += 0;
          //collision.gameObject.transform.children = gameObject.transform;

          //permite que cuando la bola choque con puntosCentro, se quede pegada
          GetComponent<Rigidbody>().isKinematic = true;

      } else
      if(collision.transform.name == "PuntosMorado")
      {
          puntosDiana.Score += 10;
          //collision.gameObject.transform.children = gameObject.transform;

          //permite que cuando la bola choque con puntosCentro, se quede pegada
          GetComponent<Rigidbody>().isKinematic = true;

      } else
        if(collision.transform.name == "PuntosVerde")
      {
          puntosDiana.Score += 20;
          //collision.gameObject.transform.children = gameObject.transform;

          //permite que cuando la bola choque con puntosCentro, se quede pegada
          GetComponent<Rigidbody>().isKinematic = true;

      }  else  
      if(collision.transform.name == "PuntosCentro")
      {
          puntosDiana.Score += 30;
          //permite que cuando la bola choque con puntosCentro, se quede pegada
          GetComponent<Rigidbody>().isKinematic = true;
      }


      // int caseSwitch = 1;

      // switch (caseSwitch)
      // {
      //     case 1:
      //         Console.WriteLine("Case 1");
      //         break;
      //     case 2:
      //         Console.WriteLine("Case 2");
      //         break;
      //     default:
      //         Console.WriteLine("Default case");
      //         break;
      // }
   
     
      
      
      
    }
}
