using UnityEngine.UI;
using UnityEngine;


public class healthBar : MonoBehaviour
{

    public Slider slider;
   

    

    public void SetMaxHealth(float health)//initilizes the max health and sets it to the max visually 
    {
        slider.maxValue = health;
        slider.value = health;

    }
    public void ChangeMaxHealth(float health) //only changes the maximum health
    {
        slider.maxValue = health;
        

    }

    public void SetHealth(float health)//allows for the damage to be appplied
    {
        slider.value = health;
    }
    
}
