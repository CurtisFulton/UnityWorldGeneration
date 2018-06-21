using System.Collections.Generic;
using UnityEngine;

public class SteppeAggregation : IBiomeAggregation
{
    private IBiomeType _coolTemperateSteppe;

    public SteppeAggregation()
    {
        _coolTemperateSteppe = new CoolTemperateSteppe();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _coolTemperateSteppe;
    }
}
