using System;
using UnityEngine;

[Serializable]
public class ColorData
{
    public string colorID;
    public Color color;

    public ColorData(string colorID, Color color)
    {
        this.colorID = colorID;
        this.color = color;
    }
}