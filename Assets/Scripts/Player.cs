using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    int health = 10;
    public int Health => health;

    float strength = 10.0f;
    public float Strength => strength;

    float speed = 5.0f;
    public float Speed => speed;

    float originalSpeed;
    float speedBoostDuration = 0.0f;
    float speedBoostTimer = 0.0f;
    bool isSpeedBoostActive = false;

    public TextMeshProUGUI HealthTMP;
    public TextMeshProUGUI StrengthTMP;
    public TextMeshProUGUI SpeedTMP;
    private void Start()
    {
        originalSpeed = speed;

        HealthTMP.text += health;
        StrengthTMP.text += strength;
        SpeedTMP.text += speed;
    }

    private void Update()
    {
        UpdateSpeedBoostTimer();
    }

    void UpdateSpeedBoostTimer()
    {
        if (isSpeedBoostActive)
        {
            speedBoostTimer += Time.deltaTime;
            Debug.Log("+++Speed Boost...");
            if (speedBoostTimer > speedBoostDuration)
            {
                speed = originalSpeed;
                isSpeedBoostActive = false;
                Debug.Log("Speed boost ended. Speed reset.");
            }
        }
    }

    public void PowerUp(int healthIncrease)
    {
        health += healthIncrease;
        Debug.Log($"Health increased by {healthIncrease}. New health: {health}");
    }
    public void PowerUp(float strengthMultiplier)
    {
        strength *= strengthMultiplier;
        Debug.Log($"Strength increased by {strengthMultiplier * 100}. New Strength: {strength}");
    }
    public void PowerUp(float speedMultiplier, float duration)
    {
        if (!isSpeedBoostActive)
        {
            speed *= speedMultiplier;
            isSpeedBoostActive = true;
            speedBoostDuration = duration;
            speedBoostTimer = 0.0f;
            Debug.Log($"Speed increased by {speedMultiplier * 100}% for {duration} second.");
        }
    }
}
