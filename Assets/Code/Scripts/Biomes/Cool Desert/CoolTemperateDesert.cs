using System.Collections.Generic;
using UnityEngine;

public class CoolTemperateDesert : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(192 / 255f, 192 / 255f, 128 / 255f);
    }
}
