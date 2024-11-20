using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) { }
    public void Attack(Character target, int amount)
    {
        target.Health -= amount;
        if (target.Health < 0) target.Health = 0;
        Debug.Log(Name + " attacked " + target.Name + " by " + amount + ". " + target.Name + "'s current health: " + target.Health);
    }
}

