﻿// Code pulled from Infallible Code on YouTube
// Found at: https://www.youtube.com/watch?v=MGx5mb5b3sY
using UnityEngine;

public interface IUnityService
{
    float GetAxis(string axisName);
    float GetDeltaTime();
}

public class UnityService : IUnityService
{
    public float GetAxis(string axisName)
    {
        return Input.GetAxis(axisName);
    }

    public float GetDeltaTime()
    {
        return Time.deltaTime;
    }
}
