using System.Collections.Generic;
using UnityEngine;

public class TropicalDryForest : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(128 / 255f, 255 / 255f, 128 / 255f);
    }
}
