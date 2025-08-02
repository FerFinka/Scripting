using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float campfireLifeTime = 15;
    public float warmRate = 0.1f;


    void Update()
    {
        campfireLifeTime -= Time.deltaTime;
        if (campfireLifeTime <= 0)
        {
            gameObject.SetActive(false);
        }
    
    }
    private void OnTriggerStay(Collider other)
    {
        Temperature temperature = other.GetComponent<Temperature>();
        if (temperature != null)
        {
            if (temperature.currentTemp < temperature.normalTemp)
            {
                temperature.currentTemp += warmRate * Time.deltaTime;
            }
        }
    }
}
