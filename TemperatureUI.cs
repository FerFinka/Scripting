using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    public Temperature playerTemperature;
    public TextMeshProUGUI temperatureText;
    void Update()
    {
        UpdateTemperatureDisplay();
    }

    void UpdateTemperatureDisplay()
    {
        
        float roundedTemp = Mathf.Round(playerTemperature.currentTemp * 10.0f) * 0.1f;

        temperatureText.text = roundedTemp.ToString();
    }
}
