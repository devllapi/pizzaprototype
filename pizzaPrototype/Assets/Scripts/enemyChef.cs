using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyChef : enemy
{
    void Start()
    {
        health = 100;
        mana = 50;
    }

    public override void attack()
    {
        heal();
    }

    public override void defend()
    {

    }

    public void heal()
    {

    }
}
