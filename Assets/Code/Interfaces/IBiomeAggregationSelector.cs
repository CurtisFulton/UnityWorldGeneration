using System.Collections;
using System.Collections.Generic;

public interface IBiomeAggregationSelector
{
    IBiomeAggregation GetBiomeAggregation(float height, float temp, float moisture);
}
