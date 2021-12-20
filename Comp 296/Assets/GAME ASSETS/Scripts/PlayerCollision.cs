using UnityEngine.SceneManagement;
using UnityEngine;
// this script is responsible for keeping track of the player's health 

public class PlayerCollision : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public healthBar healthBar;
    




    void start() // when the scnene is loaded, run these commands first
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
        //these commands will set the health values and adjust the healthbar to match the health values on initilization.

    }

     void Update()
    {
        //this will make sure that the visual healthbar is consistant with the current health value and if the player's health goes to or below 0 then show the game over screen
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        //if (Input.GetKeyDown(KeyCode.Space))//when the space bar is pressed run the function Take Damage, this is to test the palyer taking damage
        //{
        //    TakeDamage(20);//run function Take Damage and give it a value of 20
        //    healthBar.SetHealth(currentHealth);

        //}
    }

    void Heal(float heal)
    {
        currentHealth += heal;
    }

    

    void TakeDamage(float damage)// when starting this function I am ecpexting an integer in order to run properly and that integer will be refered to as damage
    {
        currentHealth -= damage; //subtract currentHealth equal to what integer was passed to damage
    }



    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        
        if (collisionInfo.collider.tag == "HealthItem") //if the player collides with an object with the tag of HealthItem then, Run the Heal method and pass it the value of 20
        {
            Heal(20);
            //Debug.Log("We just hit " + collisionInfo.collider.name);
            
        }
        

        if (collisionInfo.collider.tag == "EnemyLight") //if the player collides with an object with the tag of EnemyLight then, Run the TakeDamage method and pass it the value of 10
        {
            
            Debug.Log("We just hit " + collisionInfo.collider.name);
            TakeDamage(10);
        }
    }
}
