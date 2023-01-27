using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider barSlider;
    public Slider heartSlider;

    public void setHealth(int health){
        heartSlider.value = health;
        barSlider.value = health;
    }

    public void setMaxHealth(int health){
        heartSlider.maxValue = health;
        heartSlider.value = health;

        barSlider.maxValue = health;
        barSlider.value = health;
    }

}
