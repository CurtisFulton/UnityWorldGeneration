using System.Collections.Generic;
using UnityEngine;

public class BorealRainForest : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(32 / 255f, 160 / 255f, 192 / 255f);
    }
}
