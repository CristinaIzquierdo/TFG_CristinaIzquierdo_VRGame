using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
   {
     if(collision.transform.name == "ColisionBolos")
     {
        bolosScore.Score += 5;
     }
    }
}
