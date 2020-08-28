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
        if(instance == null)
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
        date_M = 1;
        date_Y = 1400;
    }

    void StartRound()
    {
        if (RoundStart != null)
            RoundStart();
    }

    public void EndRound(string tag)
    {
        date_M++;
        if(date_M >= 13)
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
            foreach(EventType eventType in eventTypes)
                UIManager.instance.SpawnEventManager(eventType);
        }

        if (RoundEnd != null)
            RoundEnd(tag);
    }
}
