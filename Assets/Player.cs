using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Player(string name, int health) : base(name, health) { }
    public void Heal(int amount)
    {
        Health += amount;
        if (Health > 100) Health = 100; 
        Debug.Log(Name + " healed by " + amount + ". Current health: " + Health);
    }
}
