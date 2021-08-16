using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntuacionBaloncesto : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
      if(collision.transform.name == "PalitoBaloncestoScore")
      {
          scoreBaloncesto.Score += 2;
      }
    }
}
