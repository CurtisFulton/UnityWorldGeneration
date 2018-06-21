using System.Collections.Generic;
using UnityEngine;

public class PolarAggregation : IBiomeAggregation
{
    private IBiomeType _polarIce;

    public PolarAggregation()
    {
        _polarIce = new PolarIce();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _polarIce;
    }
}
