using System.Collections.Generic;
using UnityEngine;

public class WarmTemperateMoistForest : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(96 / 255f, 224 / 255f, 128 / 255f);
    }
}
