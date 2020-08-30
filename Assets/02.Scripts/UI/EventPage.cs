using System;
using UnityEngine;
using UnityEngine.UI;

public class EventPage : MonoBehaviour
{
    public GameObject[] buttons;

    public Text titleText;
    public Text contentsText;

    public Text[] selectTexts;
    public EventPageAdditionalBox[] additionalTexts;

    public GameObject additionalBox;

    EventType et;

    private void Awake()
    {
        additionalTexts = GetComponentsInChildren<EventPageAdditionalBox>();
    }

    public void InitPage(EventType eventType)
    {
        et = null;
        et = eventType;
        string title = eventType.title;
        string content = eventType.eventContents;
        string[] selectParam = eventType.eventSelection;
        string[] additionalParam = eventType.eventAdditionalBox;

        titleText.text = title;
        contentsText.text = content;

        for (int i = 0; i < 3; i++)
        {
            selectTexts[i].text = null;
            additionalTexts[i].str_Instruction = null;
        }

        for (int i = 0; i < selectParam.Length; i++)
        {
            selectTexts[i].text = selectParam[i];
            additionalTexts[i].str_Instruction = additionalParam[i];
        }
    }

    public void OnClickButton(int idx)
    {
        if(et.effectType.Length <= idx)
        {
            return;
        }
        //Parse Event Type
        string effectType = et.effectType[idx];
        string[] types = effectType.Split('_');

        switch(types[0])
        {
            case "Ability":
                KingAbility ka = (KingAbility)Enum.Parse(typeof(KingAbility), types[1]);
                PlayerSystemManager.instance.ObtainKingAbility(ka, int.Parse(types[2]));
                break;
            case "Stat":
                PlayState ps = (PlayState)Enum.Parse(typeof(PlayState), types[1]);
                PlayerSystemManager.instance.StatingStat(ps, int.Parse(types[2]));
                break;
            default:
                Debug.Log("No Type: " + types[0]);
                break;
        }

        UIManager.instance.RemoveInPageList(gameObject);
        gameObject.SetActive(false);
    }
    
}
