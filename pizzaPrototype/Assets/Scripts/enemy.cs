using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class enemy : MonoBehaviour {

    public float health;
    public float mana;

    public abstract void attack();
    public abstract void defend();

}
