using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventPage : MonoBehaviour
{
    public GameObject[] buttons;

    public Text titleText;

    public Text[] selectTexts;

    private void Awake()
    {
        foreach(GameObject go in buttons)
        {
            go.GetComponent<Button>().onClick.AddListener(() => OnClickButton());
        }
        
    }

    public void InitPage(string titleParam, string[] selectParam)
    {
        titleText.text = titleParam;

        for(int i =0; i< selectTexts.Length; i++)
        {
            selectTexts[i].text = selectParam[i];
        }
    }

    void OnClickButton()
    {
        gameObject.SetActive(false);
    }
}
