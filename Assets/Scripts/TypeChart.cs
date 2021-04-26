﻿using System.Collections.Generic;


public static class TypeChart
{
    public enum CreatureType
    {
        None,
        Fire,
        Water,
        Grass,
        Electric 
    }
    
    // Proper usage is DamageMult[AttackType][DefendingCreatureType]
    public static Dictionary<CreatureType, Dictionary<CreatureType, float>> DamageMult =
        new Dictionary<CreatureType, Dictionary<CreatureType, float>>()
    {
        {
            CreatureType.Fire, new Dictionary<CreatureType, float>()
            {
                {CreatureType.None, 1},
                {CreatureType.Fire, 0.5f},
                {CreatureType.Water, 0.5f},
                {CreatureType.Grass, 2},
                {CreatureType.Electric, 1}
            }
        },
        {
            CreatureType.Water, new Dictionary<CreatureType, float>()
            {
                {CreatureType.None, 1},
                {CreatureType.Fire, 2},
                {CreatureType.Water, 0.5f},
                {CreatureType.Grass, 0.5f},
                {CreatureType.Electric, 1}
            }
        },
        {
            CreatureType.Grass, new Dictionary<CreatureType, float>()
            {
                {CreatureType.None, 1},
                {CreatureType.Fire, 0.5f},
                {CreatureType.Water, 2},
                {CreatureType.Grass, 0.5f},
                {CreatureType.Electric, 1}
            }
        },
        {
            CreatureType.Electric, new Dictionary<CreatureType, float>()
            {
                {CreatureType.None, 1},
                {CreatureType.Fire, 1},
                {CreatureType.Water, 2},
                {CreatureType.Grass, 0.5f},
                {CreatureType.Electric, 0.5f}
            }
        }
    };
}