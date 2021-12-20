using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {

        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);  allows for an animation to play at the bullets hit location
        //destroy(effect, 5f);  deletes the game object after 5 seconds
        //allows to get components of things it hits, meaning health bars of enemys to damage them
        Destroy(gameObject);//deletes the game object, in this case the lasert bullet

    }


}
   
