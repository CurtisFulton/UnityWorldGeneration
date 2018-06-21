using System.Collections.Generic;
using UnityEngine;

public class CoolDesertAggregation : IBiomeAggregation
{
    private IBiomeType _coolTemperateDesert;

    public CoolDesertAggregation()
    {
        _coolTemperateDesert = new CoolTemperateDesert();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _coolTemperateDesert;
    }
}
