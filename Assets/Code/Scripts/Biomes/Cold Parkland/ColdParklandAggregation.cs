using System.Collections.Generic;
using UnityEngine;

public class ColdParklandAggregation : IBiomeAggregation
{
    private IBiomeType _borealDesert;

    public ColdParklandAggregation()
    {
        _borealDesert = new BorealDesert();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _borealDesert;
    }
}
