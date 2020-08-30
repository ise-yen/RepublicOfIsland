using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineController : MonoBehaviour
{
    private MeshRenderer rendererer;

    public float maxOutlineWidth;

    public Color OutlineColor;

    private void Start()
    {
        rendererer = GetComponent<MeshRenderer>();
    }

    public void ShowOutline()
    {
        foreach(var mat in rendererer.materials)
        {
            mat.SetFloat("_Outline", maxOutlineWidth);
            mat.SetColor("_OutlineColor", OutlineColor);
        }
    }

    public void HideOutline()
    {
        foreach (var mat in rendererer.materials)
        {
            mat.SetFloat("_Outline", 0f);
        }
    }
}
