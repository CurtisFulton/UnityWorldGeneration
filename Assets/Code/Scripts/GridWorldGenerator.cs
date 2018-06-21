using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GridWorldGenerator : IWorldGenerator
{
    private INoiseGenerator _heightMapGenerator;
    private INoiseGenerator _temperatureMapGenerator;
    private INoiseGenerator _moistureMapGenerator;

    private IBiomeAggregationSelector _aggregationSelector;
    
    private MapTile[][] _allTiles;

    private int _mapSize;

    public GridWorldGenerator()
    {
    }

    // Not needed for now
    public void GenerateWorld(int size)
    {
        _mapSize = size;

        _allTiles = new MapTile[size][];

        _heightMapGenerator = CreateHeightMapGenerator();
        _temperatureMapGenerator = CreateTemperatureMapGenerator();
        _moistureMapGenerator = CreateMoistureMapGenerator();

        _aggregationSelector = new BasicBiomeSelector();

        GenerateTiles(size);
    }

    private void GenerateTiles(int size)
    {
        float minHeight = int.MaxValue, minTemp = int.MaxValue, minMoisture = int.MaxValue;
        float maxHeight = int.MinValue, maxTemp = int.MinValue, maxMoisture = int.MinValue;

        for (int x = 0; x < size; x++) {
            _allTiles[x] = new MapTile[size];
            for (int y = 0; y < size; y++) {
                float height = _heightMapGenerator.GetNoise(x, y);
                float temp = _temperatureMapGenerator.GetNoise(x, y);
                float moisture = _moistureMapGenerator.GetNoise(x, y);
                
                if (height < minHeight) minHeight = height;
                if (temp < minTemp) minTemp = temp;
                if (moisture < minMoisture) minMoisture = moisture;

                if (height > maxHeight) maxHeight = height;
                if (temp > maxTemp) maxTemp = temp;
                if (moisture > maxMoisture) maxMoisture = moisture;

                _allTiles[x][y] = new MapTile(height, temp, moisture);
            }
        }

        // Normalize the values to be between 0 and 1
        for (int x = 0; x < size; x++) {
            for (int y = 0; y < size; y++) {
                MapTile tile = _allTiles[x][y];

                var heightModifier = Mathf.Lerp(0.2f, 1.2f, tile.Height);

                tile.Height = Mathf.InverseLerp(minHeight, maxHeight, tile.Height);
                tile.Temperature = Mathf.InverseLerp(minTemp, maxTemp, tile.Temperature) * heightModifier;

                var tempModifier = Mathf.Lerp(0.2f, 1, tile.Temperature);
                
                tile.Moisture = Mathf.InverseLerp(minMoisture, maxMoisture, tile.Moisture) * tempModifier;
                
                _allTiles[x][y] = tile;
            }
        }
    }

    public Color GetTileColor(int x, int y)
    {
        var tile = GetTile(x, y);

        var height = tile.Height;
        var temp = tile.Temperature;
        var moisture = tile.Moisture;

        var colour = _aggregationSelector.GetBiomeAggregation(height, temp, moisture)
                                           .GetBiome(height, temp, moisture)
                                           .GetTileColor();
        if (height < 0.4)
            return Color.Lerp(Color.black, colour, Mathf.Lerp(0.2f, 1, height + 0.2f));
        else
            return colour;
    }

    private MapTile GetTile(int x, int y)
    {
        return _allTiles[x][y];
    }

    public float GetHeight(int x, int y)
    {
        return _allTiles[x][y].Height;
    }

    public float GetTemperature(int x, int y)
    {
        return _allTiles[x][y].Temperature;
    }

    public float GetMoisture(int x, int y)
    {
        return _allTiles[x][y].Moisture;
    }

    private INoiseGenerator CreateHeightMapGenerator()
    {
        FastNoise noise = new FastNoise();

        noise.SetSeed(Random.Range(0, int.MaxValue));
        noise.SetNoiseType(FastNoise.NoiseType.SimplexFractal);
        noise.SetFractalType(FastNoise.FractalType.FBM);

        noise.SetInterp(FastNoise.Interp.Quintic);

        noise.SetFrequency(1f / (_mapSize * 0.4f));
        noise.SetFractalLacunarity(2);
        noise.SetFractalGain(0.55f);
        noise.SetFractalOctaves(10);

        return noise;
    }

    private INoiseGenerator CreateTemperatureMapGenerator()
    {
        FastNoise noise = new FastNoise();

        noise.SetSeed(Random.Range(0, int.MaxValue));
        noise.SetNoiseType(FastNoise.NoiseType.SimplexFractal);
        noise.SetFractalType(FastNoise.FractalType.FBM);

        noise.SetInterp(FastNoise.Interp.Quintic);

        noise.SetFrequency(1f / (_mapSize * 3f));
        noise.SetFractalLacunarity(1f);
        noise.SetFractalGain(0.2f);
        noise.SetFractalOctaves(5);

        return noise;
    }

    private INoiseGenerator CreateMoistureMapGenerator()
    {
        FastNoise noise = new FastNoise();

        noise.SetSeed(Random.Range(0, int.MaxValue));
        noise.SetNoiseType(FastNoise.NoiseType.SimplexFractal);
        noise.SetFractalType(FastNoise.FractalType.FBM);

        noise.SetInterp(FastNoise.Interp.Quintic);

        noise.SetFrequency(1f / (_mapSize * 1.5f));
        noise.SetFractalLacunarity(2f);
        noise.SetFractalGain(0.5f);
        noise.SetFractalOctaves(5);

        return noise;
    }


}
