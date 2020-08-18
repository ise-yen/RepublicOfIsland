using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EventPageAdditionalBox : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject boxObject;
    RectTransform boxTransform;
    Text boxText;

    public string str_Instruction = null;

    private void OnEnable()
    {
        if (boxTransform == null)
        {
            boxTransform = boxObject.GetComponent<RectTransform>();
            boxText = boxObject.GetComponentInChildren<Text>();
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (str_Instruction == null)
            return;

        boxObject.SetActive(true);
        boxText.text = str_Instruction;
    }

    private void Update()
    {
        if (boxObject.activeSelf)
            boxTransform.position = Input.mousePosition;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        boxObject.SetActive(false);
    }
}