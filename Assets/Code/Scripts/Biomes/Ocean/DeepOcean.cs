using System.Collections.Generic;
using UnityEngine;

public class DeepOcean : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color32(0, 102, 204, 0);
    }
}
