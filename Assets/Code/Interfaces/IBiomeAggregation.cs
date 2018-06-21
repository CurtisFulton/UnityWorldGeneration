using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBiomeAggregation
{
    IBiomeType GetBiome(float height, float temp, float moisture);
}
