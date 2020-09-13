using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    #region Stat Settings
    public enum PLAYERSTAT { Britet, Tax, Dissatisfy, Comfort, Crime, Trade, Food }
    public Text[] statText;
    #endregion

    #region ABILITY Settings
    public Text abilityText;
    #endregion

    public Text dateText;

    public GameObject eventPagePrefab;
    public List<GameObject> eventPageList = new List<GameObject>();

    public TextMeshProUGUI endingText;

    public GameObject eventDataPanel;

    public Button endButton;

    string[] example = { "왕은 똑똑해야지!", "왕도 돈이 있어야 돼!", "왕은 힘이 제일이지!" };
    string[] example2 = { "행정력 + 1", "경제력 + 1", "군사력 + 1" };

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        RoundManager.instance.RoundEnd += SpawnEndingUI;
        SetDate();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
            SpawnBuildingPage(Building.Church, 0);
    }

    public void DisableButton()
    {
        endButton.interactable = false;
    }

    public void EnableButton()
    {
        endButton.interactable = true;
    }

    public void SetPlayerStat(PlayState stat, int param)
    {
        statText[(int)stat - 1].text = param.ToString();
    }

    public void SpawnEndingUI(string tag)
    {
        endingText.enabled = true;
        endingText.text = tag;

        StartCoroutine(CoSpawnRoundEndingUI());
    }

    public void SetAbilityUI(int administrativePower, int economicPower, int warPower)
    {
        string tmpString = null;
        tmpString = "왕 능력치(";
        tmpString += administrativePower + "/";
        tmpString += economicPower + "/";
        tmpString += warPower + ")";

        abilityText.text = tmpString;
    }

    public void SetDate()
    {
        string str_Date = null;
        str_Date += RoundManager.instance.date_Y;
        str_Date += "년 ";
        str_Date += RoundManager.instance.date_M;
        str_Date += "월";
        dateText.text = str_Date;
    }

    public void RemoveInPageList(GameObject go)
    {
        if (go != null)
        {
            if (eventPageList.Contains(go))
            {
                eventPageList.Remove(go);
            }
        }
        if (eventPageList.Count == 0)
        {
            EnableButton();
        }
    }

    public void ShowEventDataList()
    {
        eventDataPanel.SetActive(true);
    }

    public void SpawnBuildingPage(Building building, int level)
    {
        var go = Instantiate(eventPagePrefab, transform);
        go.GetComponent<EventPage>().InitPage(building, level);

        RectTransform rt = go.GetComponent<RectTransform>();
        rt.localPosition = new Vector3(0, 0, 0) + new Vector3(30, -30) * eventPageList.Count;
        rt.localScale = Vector3.one;
        eventPageList.Add(go);
    }

    public void SpawnEventPage(EventType eventType)
    {
        //for(int i = 0; i <eventPageList.Count; i++)
        //{
        //    if(!eventPageList[i].activeSelf)
        //    {
        //        eventPageList.RemoveAt(i);
        //    }
        //}
        var go = Instantiate(eventPagePrefab, transform);

        RectTransform rt = go.GetComponent<RectTransform>();
        go.GetComponent<EventPage>().InitPage(eventType);
        rt.localPosition = new Vector3(0, 0, 0) + new Vector3(30, -30) * eventPageList.Count;
        rt.localScale = Vector3.one;
        eventPageList.Add(go);
    }

    public IEnumerator CoSpawnRoundEndingUI()
    {
        yield return new WaitForSeconds(1f);
        endingText.enabled = false;
        RoundManager.instance.StartRound();
        SetDate();
    }
}

public enum Building { Church, Court }