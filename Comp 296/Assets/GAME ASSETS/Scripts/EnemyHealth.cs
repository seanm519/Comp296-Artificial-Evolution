using UnityEngine.UI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyhealth = 100f;
    public float damagevalue = 20f;
    public float scoreValue = 100f;
    


    private void Update()
    {
        if (enemyhealth == 0) //this script will check if the health of the enemy os zero and if it is, "kill" the enemy and award the palyer with a score
        {
            
            Destroy(gameObject); //destroy will delete the object from the scene, putting gameObject in the parenthesis will delete the object that this script is attatched to
            FindObjectOfType<ScoreTracker>().scoreUpdate(scoreValue);// find the object ScoreTracker and within that script run the method scoreUpdate and pass in the value scoreValue
        }
    }
    private void OnCollisionEnter2D(Collision2D collisionInfo) // when this object collides with any other collider run the code below.
    {
        if (collisionInfo.collider.tag == "Player") // if the thing that I collide with has the tag of Player then I need to take damage
        {

            TakeDamage(damagevalue); // run the TakeDamage method and pass in the value of damagevalue
            Debug.Log("We just got hit by " + collisionInfo.collider.name); //this is a test case to make sure that the object we are colliding with has the correct tag
        }
    }

    void TakeDamage(float damage) //this code is responsible for adjusting the health of the enemy by what value is passed to this method, the value should be a float and for this method will be refered to as damage.
    {
        enemyhealth -= damage;
    }



    
}
