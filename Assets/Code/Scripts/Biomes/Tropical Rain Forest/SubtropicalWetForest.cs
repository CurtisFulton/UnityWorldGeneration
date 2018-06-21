using System.Collections.Generic;
using UnityEngine;

public class SubtropicalWetForest : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(64 / 255f, 240 / 255f, 176 / 255f);
    }
}
