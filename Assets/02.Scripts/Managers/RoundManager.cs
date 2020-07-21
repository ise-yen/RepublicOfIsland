using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoundManager : MonoBehaviour
{
    public static RoundManager instance;

    public UnityAction RoundStart;
    public UnityAction<string> RoundEnd;

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
    }

    void StartRound()
    {
        if (RoundStart != null)
            RoundStart();
    }

    public void EndRound(string tag)
    {
        if (RoundEnd != null)
            RoundEnd(tag);
    }
}
