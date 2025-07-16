using UnityEngine;

// INHERTIANCE
public class PaintAllPowerUp : PowerUp
{
    protected override void Execute()
    {
        foreach (var box in _boxManager.boxes)
        {
            if (box != null) 
                box.InitializeBox(_boxManager.colorPalette[_boxManager.CurrentColorIndex]);
        }
    }
}
