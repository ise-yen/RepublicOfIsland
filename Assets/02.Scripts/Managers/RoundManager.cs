using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Linq;

public class RoundManager : MonoBehaviour
{
    public static RoundManager instance;

    public UnityAction RoundStart;
    public UnityAction<string> RoundEnd;

    public int date_M;
    public int date_Y;

    EventData eventData = new EventData();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        SceneManager.LoadScene("LevelUI", LoadSceneMode.Additive);
    }

    private void Start()
    {
        if (GlobalManager.instance.userData != null)
        {
            date_M = GlobalManager.instance.userData.date_M;
            date_Y = GlobalManager.instance.userData.date_Y;
        }
        else
        {
            date_M = 12;
            date_Y = 1399;
        }
        StartRound();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            DataManager.SaveData();
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            UserData data = DataManager.LoadData();

            date_Y = data.date_Y;
            date_M = data.date_M;

            UIManager.instance.SetDate();
        }
    }

    public void StartRound()
    {
        date_M++;
        if (date_M >= 13)
        {
            date_M = 1;
            date_Y++;
        }

        var eventTypes = from eventType in eventData.eventList
                         where eventType.date_M == date_M
                         where eventType.date_Y == date_Y
                         select eventType;

        if (eventTypes != null)
        {
            foreach (EventType eventType in eventTypes)
                UIManager.instance.SpawnEventManager(eventType);
        }

        UIManager.instance.RemoveInPageList(null);
    }

    public void EndRound(string tag)
    {
        UIManager.instance.DisableButton();

        if (RoundEnd != null)
            RoundEnd(tag);
    }
}
