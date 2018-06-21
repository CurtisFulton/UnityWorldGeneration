using System.Collections.Generic;
using UnityEngine;

public class TropicalVeryDryForest : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(160, 255, 128);
    }
}
