using System.Collections.Generic;
using UnityEngine;

public class BorealDesert : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(160 / 255f, 160 / 255f, 128 / 255f);
    }
}
