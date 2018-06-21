using System.Collections.Generic;
using UnityEngine;

public class TropicalRainForest : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(32 / 255f, 255 / 255f, 160 / 255f);
    }
}
