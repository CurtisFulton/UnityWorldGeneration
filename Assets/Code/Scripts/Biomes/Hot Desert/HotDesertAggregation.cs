using System.Collections.Generic;
using UnityEngine;

public class HotDesertAggregation : IBiomeAggregation
{
    private IBiomeType _tropicalDesert;

    public HotDesertAggregation()
    {
        _tropicalDesert = new TropicalDesert();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _tropicalDesert;
    }
}
