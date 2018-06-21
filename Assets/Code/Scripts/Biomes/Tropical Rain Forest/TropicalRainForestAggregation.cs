using System;

public class TropicalRainForestAggregation : IBiomeAggregation
{
    private IBiomeType _tropicalRainForest;
    private IBiomeType _subtropicalWetForest;

    public TropicalRainForestAggregation()
    {
        _tropicalRainForest = new TropicalRainForest();
        _subtropicalWetForest = new SubtropicalWetForest();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        return _tropicalRainForest;
    }
}