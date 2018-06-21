using System.Collections.Generic;
using UnityEngine;

public class PolarIce : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(255 / 255f, 255 / 255f, 255 / 255f);
    }
}
