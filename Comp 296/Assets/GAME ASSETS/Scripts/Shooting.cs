using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;







    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))   
        {
            Shoot();
        }

    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);//creates the laser blast in the game world
        Rigidbody2D bulletBody = bullet.GetComponent<Rigidbody2D>();// create a rigid body on the laser and get the component
        bulletBody.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);//add a force for the laser to "shoot"

        
    }


}
