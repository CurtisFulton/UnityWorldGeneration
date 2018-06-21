using System.Collections.Generic;
using UnityEngine;

public class TundraAggregation : IBiomeAggregation
{
    private IBiomeType _subpolarRainTundra;

    public TundraAggregation()
    {
        _subpolarRainTundra = new SubpolarRainTundra();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _subpolarRainTundra;
    }
}
