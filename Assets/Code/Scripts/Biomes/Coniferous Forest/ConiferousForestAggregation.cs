using System.Collections.Generic;
using UnityEngine;

public class ConfierousForestAggregation : IBiomeAggregation
{
    private IBiomeType _borealRainForest;

    public ConfierousForestAggregation()
    {
        _borealRainForest = new BorealRainForest();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _borealRainForest;
    }
}
