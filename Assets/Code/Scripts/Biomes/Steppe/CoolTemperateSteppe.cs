using System.Collections.Generic;
using UnityEngine;

public class CoolTemperateSteppe : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(128 / 255f, 192 / 255f, 128 / 255f);
    }
}
