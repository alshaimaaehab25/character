using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
 private string name;
    private int health;
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                health = value;
            }
            else
            {
                health = 100;
            }
        }
    }
}

