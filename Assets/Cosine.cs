using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosine
{
    public static Vector2 Interpolation(List<Vector2> list, float t, int x)
    {
        float range = 1f / (list.Count - 1);
        int index = Mathf.FloorToInt(t / range);

        float dt = Mathf.InverseLerp(range * index, range * (index + 1), t);

        float dt2 = (1f - Mathf.Cos(dt * Mathf.PI)) / 2f;

        var vec1 = list[index] * (1 - dt2) + list[index + 1] * dt2;
        var vec2 = list[index] * (1 - dt) + list[index + 1] * dt;

        return new Vector2(vec2.x, vec1.y);
    }
}