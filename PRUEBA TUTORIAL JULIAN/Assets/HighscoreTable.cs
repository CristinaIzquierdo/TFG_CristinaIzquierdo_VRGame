using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighscoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;

    private void Awake() 
    {
        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        float templateHeight = 20f;
        for(int i = 0; i < 10; i++){
            Transform entryTrasform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTrasform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTrasform.gameObject.SetActive(true);
        }




    }
}
