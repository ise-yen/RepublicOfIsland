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

    private void Initialize(int idx)
    {
        foreach(GameObject button in buttons)
        {
            button.GetComponent<Button>().enabled = false;
        }

        for(int i = 0; i < idx; i++)
        {
            buttons[i].GetComponent<Button>().enabled = true;
        }
    }


    public void InitPage(Building build, int level)
    {
        string title = "Church";
        string content = "교회를 진화시키겠습니까?";
        string[] selectParam = new string[2] { "예", "아니오" };
        string[] additionParam = new string[2] { "Briket - 20", "Briket - 40" };
        if(build == Building.Church)
        {

        }
        else if(build == Building.Court)
        {

        }
        titleText.text = title;
        contentsText.text = content;
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

        Initialize(selectParam.Length);
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
            case "Religion":
                RELIGION rel = (RELIGION)Enum.Parse(typeof(RELIGION), types[1]);
                //Adjust Religion Stat
                break;
            case "Random":
                RandomStat(types[1], types[2]);
                break;
            case "Military":
                break;
            case "Trade":
                break;
            default:
                Debug.Log("No Type: " + types[0]);
                break;
        }

        UIManager.instance.RemoveInPageList(gameObject);
        gameObject.SetActive(false);
    }

    void RandomStat(string type, string num)
    {
        string[] nums = num.Split('\'');
        int[] 

        switch (type)
        {
            case "Ability":
                break;
            case "Briket":
                break;
            case "Food":
                break;
            case "Army":
                break;
        }
    }

    void UpgradeBuilding()
    {

    }
}

public enum RELIGION { Catholic, Islam, Christ }