using System;
using System.Collections.Generic;
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

public class BoxManager : MonoBehaviour
{
    public List<ColorData> colorPalette = new List<ColorData>();
    public BoxObject referenceBox;
    public BoxObject boxPrefab;
    public Vector2 dimensions;

    //ABSTRACTION
    public string CurrentColorID { get; private set; }

    private void Start()
    {
        int colorIndex = UnityEngine.Random.Range(0, colorPalette.Count);
        referenceBox.InitializeBox(colorPalette[colorIndex]);
        CurrentColorID = colorPalette[colorIndex].colorID;
        CreateBoxes();
    }

    public void CreateBoxes()
    {
        float xStart = (dimensions.x - 1) * -0.5f;
        float yStart = (dimensions.y - 1) * -0.5f;

        for (int x = 0; x < dimensions.x; x++)
        {
            for (int y = 0; y < dimensions.y; y++)
            {
                BoxObject spawnedBox = Instantiate(boxPrefab, transform);
                spawnedBox.transform.localPosition = new Vector3(xStart + x, yStart + y, 0f);
                int colorIndex = UnityEngine.Random.Range(0, colorPalette.Count);
                spawnedBox.InitializeBox(colorPalette[colorIndex]);
            }
        }
    }
}
