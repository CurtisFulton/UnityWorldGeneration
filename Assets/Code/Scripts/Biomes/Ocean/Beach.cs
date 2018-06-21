using System.Collections.Generic;
using UnityEngine;

public class Beach : IBiomeType
{
    public Color GetTileColor()
    {
        return Color.yellow;
    }
}
