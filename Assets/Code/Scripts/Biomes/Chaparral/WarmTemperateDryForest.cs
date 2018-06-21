using System.Collections.Generic;
using UnityEngine;

public class WarmTemperateDryForest : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(128 / 255f, 224 / 255f, 128 / 255f);
    }
}
