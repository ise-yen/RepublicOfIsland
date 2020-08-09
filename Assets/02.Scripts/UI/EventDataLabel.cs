using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventDataLabel : MonoBehaviour
{
    public Text dateText;
    public Text contentText;

    public void SetTextToData(string date, string content)
    {
        dateText.text = date;
        contentText.text = content;
    }
}
