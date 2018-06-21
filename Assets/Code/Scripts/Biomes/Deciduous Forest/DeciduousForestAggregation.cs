using System.Collections.Generic;
using UnityEngine;

public class DeciduousForestAggregation : IBiomeAggregation
{
    private IBiomeType _warmTemperateMoiseForest;

    public DeciduousForestAggregation()
    {
        _warmTemperateMoiseForest = new WarmTemperateMoistForest();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _warmTemperateMoiseForest;
    }
}
