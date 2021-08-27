using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnBall : MonoBehaviour
{

    public GameObject BolaBolos;
    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
     // Instantiate(BolaBolos, new Vector3(5.356f,0.1307565f,-6.147f), Quaternion.identity);                

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer==20f){
            Instantiate(BolaBolos, new Vector3(5.356f,0.1307565f,-6.147f), Quaternion.identity);                
        }

    }
}
