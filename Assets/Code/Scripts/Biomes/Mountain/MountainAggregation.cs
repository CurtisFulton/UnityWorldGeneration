using System.Collections.Generic;
using UnityEngine;

public class MountainAggregation : IBiomeAggregation
{
    private IBiomeType _mountainSide;
    private IBiomeType _mountainTop;

    public MountainAggregation()
    {
        _mountainSide = new MountainSide();
        _mountainTop = new MountainTop();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        if (height > 0.85)
            return _mountainTop;
        else
            return _mountainSide;
    }
}
