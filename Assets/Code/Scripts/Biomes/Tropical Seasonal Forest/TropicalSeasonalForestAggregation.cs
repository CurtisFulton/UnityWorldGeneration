using System.Collections.Generic;
using UnityEngine;

public class TropicalSeasonalForestAggregation : IBiomeAggregation
{
    private IBiomeType _tropicalDryForest;

    public TropicalSeasonalForestAggregation()
    {
        _tropicalDryForest = new TropicalDryForest();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _tropicalDryForest;
    }
}
