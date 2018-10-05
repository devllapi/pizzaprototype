﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class enemy : MonoBehaviour {

    public float health;
    public float maxHealth;
    public float mana;
    public float maxMana;
    public bool isDefending;
    public GameObject glowObj;

    public Image enemyHealthBar;
    public Image enemyManaBar;

    public abstract void attack();
    
    public void takeDamage(float dmg)
    {
        if (isDefending)
        {
            health -= dmg / 2;
        }
        else
        {
            health -= dmg;
        }
    }

    public void defend()
    {
        isDefending = true;
    }

    public abstract void glow();
}