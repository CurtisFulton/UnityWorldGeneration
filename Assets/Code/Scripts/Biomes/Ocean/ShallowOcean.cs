using System.Collections.Generic;
using UnityEngine;

public class ShallowOcean : IBiomeType
{
    public Color GetTileColor()
    {
        return Color.cyan;
    }
}
