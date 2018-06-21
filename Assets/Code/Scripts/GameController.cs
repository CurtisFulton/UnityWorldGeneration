using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class GameController : MonoBehaviour
{
    private IWorldGenerator WorldGenerator { get; set; }

    [SerializeField] private int _worldSize;

    [SerializeField] private Renderer _renderer;
    [SerializeField] private Terrain _terrain;

    private float max = int.MinValue;
    private float min = int.MaxValue;

    private void Awake()
    {
        WorldGenerator = new GridWorldGenerator();
        WorldGenerator.GenerateWorld(_worldSize);
    }

    private void Start()
    {
        Texture2D worldTexture = new Texture2D(_worldSize, _worldSize);

        var colors = new Color[_worldSize * _worldSize];

        for (int x = 0; x < _worldSize; x++) {
            for (int y = 0; y < _worldSize; y++) {
                var i = (x * _worldSize) + y;
                var colour = GetMapColor(x, y);
                //var colour = GetMoistureTexture(x, y);

                colors[i] = colour;
            }
        }

        worldTexture.SetPixels(colors);

        worldTexture.Apply();

        _renderer.material.mainTexture = worldTexture;

        var heights = new float[_worldSize, _worldSize];

        _terrain.heightmapPixelError = 0;
        _terrain.terrainData.heightmapResolution = Mathf.NextPowerOfTwo(_worldSize) + 1;
        _terrain.terrainData.size = new Vector3(_worldSize, 35, _worldSize);
        _terrain.basemapDistance = Mathf.Infinity;

        var texture = new SplatPrototype[] { new SplatPrototype() } ;
        texture[0].texture = worldTexture;
        texture[0].tileSize = new Vector2(_worldSize, _worldSize);

        _terrain.terrainData.splatPrototypes = texture;

        for (int x = 0; x < _worldSize; x++) {
            for (int y = 0; y < _worldSize; y++) {
                var i = (x * _worldSize) + y;
                var height = WorldGenerator.GetHeight(x, y);

                if (height < 0.35)
                    height = 0.35f;

                heights[x, y] = height;
            }
        }

        _terrain.terrainData.SetHeights(0, 0, heights);
    }

    private Color GetMapColor(int x, int y)
    {
        return WorldGenerator.GetTileColor(x, y);
    }

    private Color GetHeightMap(int x, int y)
    {
        float height = WorldGenerator.GetHeight(x, y);

        if (height > max) max = height;
        if (height < min) min = height;

        return new Color(height, height, height);
    }

    private Color GetTemperatureMap(int x, int y)
    {
        float height = WorldGenerator.GetTemperature(x, y);

        if (height > max) max = height;
        if (height < min) min = height;

        return new Color(height, height, height);
    }

    private Color GetMoistureTexture(int x, int y)
    {
        float height = WorldGenerator.GetMoisture(x, y);

        if (height > max) max = height;
        if (height < min) min = height;

        return new Color(height, height, height);
    }
}
