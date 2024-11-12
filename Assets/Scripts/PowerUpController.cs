using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();
            PowerUp powerUp = GetComponent<PowerUp>();
            if (powerUp != null || player != null) 
            {
                powerUp.ApplyPowerUp(player);
                Destroy(gameObject);
            }
        }
    }
}
