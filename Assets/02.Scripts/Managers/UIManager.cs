using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    #region Ability Settings
    public enum ABILITY { Tax, Dissatisfy, Comfort, Crime, Trade, Food }
    public Transform[] abilityText;
    #endregion

    public GameObject eventPagePrefab;
    public List<GameObject> eventPageList = new List<GameObject>();

    public TextMeshProUGUI endingText;

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
            SpawnEventManager();
        }
    }

    public void SetAbilityUI(ABILITY ability, string param)
    {
        abilityText[(int)ability].GetComponentInChildren<Text>().text = param;
    }

    public void SpawnEventManager()
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
        rt.localPosition = new Vector3(0, 0, 0) + new Vector3(30, -30) * eventPageList.Count;
        rt.localScale = Vector3.one;
        eventPageList.Add(go);
    }

    public void SpawnEndingUI(string tag)
    {
        endingText.enabled = true;
        endingText.text = tag;

        StartCoroutine(CoSpawnEndingUI());
    }

    public IEnumerator CoSpawnEndingUI()
    {
        yield return new WaitForSeconds(1f);
        endingText.enabled = false;
    }
}
