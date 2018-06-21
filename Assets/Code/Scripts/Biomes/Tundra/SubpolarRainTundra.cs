﻿using System.Collections.Generic;
using UnityEngine;

public class SubpolarRainTundra : IBiomeType
{
    public Color GetTileColor()
    {
        return new Color(32 / 255f, 128 / 255f, 192 / 255f);
    }
}
