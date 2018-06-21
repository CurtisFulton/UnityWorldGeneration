using System.Collections.Generic;
using UnityEngine;

public class MixedForestAggregation : IBiomeAggregation
{
    private IBiomeType _coolTemperateWetForest;

    public MixedForestAggregation()
    {
        _coolTemperateWetForest = new CoolTemperateWetForest();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _coolTemperateWetForest;
    }
}
