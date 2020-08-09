using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDataHandler : MonoBehaviour
{
    public Transform eventDataParent;

    [SerializeField]
    EventDataLabel[] eventDataList;

    int labelNum;

    private void Awake()
    {
        eventDataList = eventDataParent.GetComponentsInChildren<EventDataLabel>();

    }

    private void Start()
    {
        eventDataList[0].SetTextToData("1400년 1월", "Welcome To ROI");
    }

}
