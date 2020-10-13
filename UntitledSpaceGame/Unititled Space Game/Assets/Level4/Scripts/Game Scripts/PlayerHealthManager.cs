using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    // Start is called before the first frame update
   public Slider slider;
    void Start(){
        slider = GetComponent<Slider>();
    }

    public void SetHealth(float health){
        slider.value = health;
    }
    public void SetMaxHealth(float health){
        slider.maxValue = health;
        slider.value = health;
    }   
}
