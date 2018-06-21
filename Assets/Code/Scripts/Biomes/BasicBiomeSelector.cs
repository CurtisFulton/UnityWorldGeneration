using System;
using System.Collections.Generic;

public class BasicBiomeSelector : IBiomeAggregationSelector
{
    private IBiomeAggregation _oceanAggregation;
    private IBiomeAggregation _polarAggregation;
    private IBiomeAggregation _tundraAggregation;
    private IBiomeAggregation _coldParklandAggregation;
    private IBiomeAggregation _coniferousForestAggregation;
    private IBiomeAggregation _mixedForestAggregation;
    private IBiomeAggregation _steppesAggregation;
    private IBiomeAggregation _coolDesertAggregation;
    private IBiomeAggregation _deciduousForestAggregation;
    private IBiomeAggregation _chaparralAggregation;
    private IBiomeAggregation _hotDesertAggregation;
    private IBiomeAggregation _savannaAggregation;
    private IBiomeAggregation _tropicalSeasonalForestAggregation;
    private IBiomeAggregation _tropicalRainForestAggregation;
    private IBiomeAggregation _mountainAggregation;


    public BasicBiomeSelector()
    {
        _oceanAggregation = new OceanAggregation();

        _polarAggregation = new PolarAggregation();
        _tundraAggregation = new TundraAggregation();
        _coldParklandAggregation = new ColdParklandAggregation();
        _coniferousForestAggregation = new ConfierousForestAggregation();
        _mixedForestAggregation = new MixedForestAggregation();
        _steppesAggregation = new SteppeAggregation();
        _coolDesertAggregation = new CoolDesertAggregation();
        _deciduousForestAggregation = new DeciduousForestAggregation();
        _chaparralAggregation = new ChaparralAggregation();
        _hotDesertAggregation = new HotDesertAggregation();
        _savannaAggregation = new SavannaAggregation();
        _tropicalSeasonalForestAggregation = new TropicalSeasonalForestAggregation();
        _tropicalRainForestAggregation = new TropicalRainForestAggregation();
        _mountainAggregation = new MountainAggregation();
    }

    public IBiomeAggregation GetBiomeAggregation(float height, float temp, float moisture)
    {
        if (height < 0.45f)
            return _oceanAggregation;

        if (height > 0.75)
            return _mountainAggregation;

        if (moisture < Humidity.Arid && temp < Temperature.Polar)
            return _polarAggregation;
        //else if (moisture < Humidity.Semiarid && temp < Temperature.Subpolar)
            //return _tundraAggregation;
        else if (moisture < Humidity.Perarid && temp < Temperature.Boreal)
            return _coldParklandAggregation;
        else if (moisture < Humidity.Perarid && temp < Temperature.CoolTemperate)
            return _coolDesertAggregation;
        else if (moisture < Humidity.Perarid && temp < Temperature.Tropical)
            return _hotDesertAggregation;

        //else if (moisture < Humidity.Subhumid && temp < Temperature.Boreal)
            //return _coniferousForestAggregation;
        else if (moisture < Humidity.Arid && temp < Temperature.CoolTemperate)
            return _steppesAggregation;
        //else if (moisture < Humidity.Humid && temp < Temperature.CoolTemperate)
            //return _mixedForestAggregation;
        else if (moisture < Humidity.Semiarid && temp < Temperature.WarmTemperate)
            return _chaparralAggregation;
        //else if (moisture < Humidity.Perhumid && temp < Temperature.WarmTemperate)
            //return _deciduousForestAggregation;
        else if (moisture < Humidity.Arid && temp < Temperature.SubTropical)
            return _savannaAggregation;
        else if (moisture < Humidity.Subhumid && temp < Temperature.SubTropical)
            return _tropicalSeasonalForestAggregation;
        else if (moisture < Humidity.Semiarid && temp < Temperature.Tropical)
            return _savannaAggregation;
        else if (moisture < Humidity.Subhumid && temp < Temperature.Tropical)
            return _tropicalSeasonalForestAggregation;
        else
            return _tropicalRainForestAggregation;
    }
}