using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventPage : MonoBehaviour
{
    public GameObject[] buttons;

    private void Awake()
    {
        foreach(GameObject go in buttons)
        {
            go.GetComponent<Button>().onClick.AddListener(() => OnClickButton());
        }
        
    }

    public void InitPage()
    {
    }

    void OnClickButton()
    {
        gameObject.SetActive(false);
    }
}
