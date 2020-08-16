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
    public EventPageAdditionalBox[] additionalTexts;

    public GameObject additionalBox;

    private void Awake()
    {
        foreach(GameObject go in buttons)
        {
            go.GetComponent<Button>().onClick.AddListener(() => OnClickButton());
        }

        additionalTexts = GetComponentsInChildren<EventPageAdditionalBox>();
    }

    public void InitPage(string titleParam, string[] selectParam, string[] additionParam)
    {
        titleText.text = titleParam;

        for (int i = 0; i < 3; i++)
        {
            selectTexts[i].text = null;
            additionalTexts[i].str_Instruction = null;
        }

            for (int i =0; i< selectTexts.Length; i++)
        {
            selectTexts[i].text = selectParam[i];
            additionalTexts[i].str_Instruction = additionParam[i];
        }
    }

    void OnClickButton()
    {
        gameObject.SetActive(false);
    }
}
