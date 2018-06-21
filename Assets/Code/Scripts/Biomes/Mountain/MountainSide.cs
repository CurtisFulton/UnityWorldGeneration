using System.Collections.Generic;
using UnityEngine;

public class MountainSide : IBiomeType
{
    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        throw new System.NotImplementedException();
    }

    public Color GetTileColor()
    {
        return Color.grey;
    }
}
