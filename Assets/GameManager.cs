using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Player1", 70);
        Enemy enemy = new Enemy("Enemy1", 50);
        Debug.Log(player.Name + "'s health: " + player.Health);
        Debug.Log(enemy.Name + "'s health: " + enemy.Health);
        player.Heal(20);
        enemy.Attack(player, 30);
    }
}