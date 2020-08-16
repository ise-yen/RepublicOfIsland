using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    #region Stat Settings
    public enum PLAYERSTAT { Tax, Dissatisfy, Comfort, Crime, Trade, Food }
    public Text[] statText;
    #endregion

    #region ABILITY Settings
    public Text abilityText;
    #endregion

    public GameObject eventPagePrefab;
    public List<GameObject> eventPageList = new List<GameObject>();

    public TextMeshProUGUI endingText;

    public GameObject eventDataPanel;

    string[] example = { "왕은 똑똑해야지!", "왕도 돈이 있어야 돼!", "왕은 힘이 제일이지!" };
    string[] example2 = { "행정력 + 1", "경제력 + 1", "군사력 + 1" };

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        RoundManager.instance.RoundEnd += SpawnEndingUI;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnEventManager("로이 세계에 오신 것을 진심으로 환영합니다. 여러분을 위해 준비한 작은 선물입니다.", example, example2);
        }
    }

    public void SetPlayerStat(PLAYERSTAT stat, int param)
    {
        statText[(int)stat].text = param.ToString();
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


    public void ShowEventDataList()
    {
        eventDataPanel.SetActive(true);
    }

    public void SpawnEventManager(string titleParam, string[] selectParam, string[] additionalParam)
    {
        for(int i = 0; i <eventPageList.Count; i++)
        {
            if(!eventPageList[i].activeSelf)
            {
                eventPageList.RemoveAt(i);
            }
        }

        var go = Instantiate(eventPagePrefab, transform);

        RectTransform rt = go.GetComponent<RectTransform>();
        go.GetComponent<EventPage>().InitPage(titleParam, selectParam, additionalParam);
        rt.localPosition = new Vector3(0, 0, 0) + new Vector3(30, -30) * eventPageList.Count;
        rt.localScale = Vector3.one;
        eventPageList.Add(go);
    }

    public IEnumerator CoSpawnRoundEndingUI()
    {
        yield return new WaitForSeconds(1f);
        endingText.enabled = false;
    }
}
