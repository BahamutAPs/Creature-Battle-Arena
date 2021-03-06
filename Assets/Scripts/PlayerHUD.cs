﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    public Text Name;
    public Text HealthDisplay;
    public HealthBar HealthBar;
    public Image CreatureSprite;

    public void InitializeHUD(CreatureData creature)
    {
        if (creature == null)
        {
            Name.text = "";
            SetMaxHealth(0);
            SetHealth(0);
        }
        else
        {
            Name.text = creature.Name;
            SetMaxHealth(creature.MaxHealth);
            SetHealth(creature.CurrentHealth);
            CreatureSprite.sprite = creature.Sprite;
        }
        
    }

    private void SetMaxHealth(int health)
    {
        HealthBar.SetMaxHealth(health);
    }

    public void SetHealth(int health)
    {
        HealthBar.SetHealth(health);
        SetHealthDisplayText(health);
    }

    public int GetHealth()
    {
        return HealthBar.GetHealth();
    }

    private void SetHealthDisplayText(int health)
    {
        HealthDisplay.text = health + " / " + HealthBar.GetMaxHealth();
    }
}
