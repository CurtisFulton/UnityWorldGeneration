using System.Collections.Generic;
using UnityEngine;

public class ChaparralAggregation : IBiomeAggregation
{
    private IBiomeType _warmTemperateDryForest;

    public ChaparralAggregation()
    {
        _warmTemperateDryForest = new WarmTemperateDryForest();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _warmTemperateDryForest;
    }
}
