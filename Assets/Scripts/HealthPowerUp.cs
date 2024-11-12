using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : PowerUp
{
    public int healthIncrease;

    public void Start()
    {
        healthIncrease = 20;
    }

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(healthIncrease);
        player.HealthTMP.text = "Health Text :" + player.Health;
    }
}
