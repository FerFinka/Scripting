using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public float normalTemp = 36.6f;
    public float currentTemp = 36.6f;
    public float criticalTemp = 34.0f;
    private float tempDecrease = 0.1f;
    public int healthDamage = 1;
    public Health health;
    public float freezeDamageTimer = 1;
    public float freezeDamageDelay = 2;

    
    void Update()
    {
        currentTemp -= tempDecrease * Time.deltaTime;
        if (currentTemp <= criticalTemp)
        {
            if (freezeDamageTimer <= 0)
            {
                health.TakeDamage(healthDamage);
                freezeDamageTimer = freezeDamageDelay;
            }
            else
            {
                freezeDamageTimer -= Time.deltaTime;
            }
        }
    }
}
