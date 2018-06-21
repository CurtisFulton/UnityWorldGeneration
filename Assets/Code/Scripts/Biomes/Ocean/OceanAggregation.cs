using System.Collections.Generic;
using UnityEngine;

public class OceanAggregation : IBiomeAggregation
{
    private IBiomeType ShallowOcean { get; set; }
    private IBiomeType DeepOcean { get; set; }
    private IBiomeType IceOcean { get; set; }
    private IBiomeType Beach { get; set; }

    public OceanAggregation()
    {
        ShallowOcean = new ShallowOcean();
        DeepOcean = new DeepOcean();
        IceOcean = new IceOcean();
        Beach = new Beach();
    }

    public IBiomeType GetBiome(float height, float temp, float moisture)
    {
        if (height > 0.41f && temp > 0.315f)
            return Beach;

        if (height > 0.35f)
            return ShallowOcean;

        return DeepOcean;
    }
}
