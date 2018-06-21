using System.Collections.Generic;
using UnityEngine;

public class CoolTemperateWetForest : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(64 / 255f, 192 / 255f, 144 / 255f);
    }
}
