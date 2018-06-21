using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWorldGenerator
{
    void GenerateWorld(int size);
    Color GetTileColor(int x, int y);
    float GetHeight(int x, int y);
    float GetTemperature(int x, int y);
    float GetMoisture(int x, int y);
}
