using System.Collections.Generic;
using UnityEngine;

public class SavannaAggregation : IBiomeAggregation
{
    private IBiomeType _tropicalVeryDryForest;

    public SavannaAggregation()
    {
        _tropicalVeryDryForest = new TropicalVeryDryForest();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _tropicalVeryDryForest;
    }
}
