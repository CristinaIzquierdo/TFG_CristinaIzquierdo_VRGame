using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class getName : MonoBehaviour
{
        public GameObject NombreLabel;
            private Text UIText;


    // Start is called before the first frame update
    void Start()
    {
         UIText = NombreLabel.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        UIText = NombreLabel.GetComponent<Text>();
    }
}
