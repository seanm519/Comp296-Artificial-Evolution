using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform enemyfirePoint;
    public GameObject bulletPrefab;
    public float bulletforce = 10f;



     void Start()
    {
        StartCoroutine(ShootTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
        
        

    }


    IEnumerator ShootTimer()
    {
        
        
        shoot();
        yield return new WaitForSeconds(2);
        Start();

    }


    void shoot()
    {
        GameObject Enemybullet = Instantiate(bulletPrefab, enemyfirePoint.position, enemyfirePoint.rotation);//creates the laser blast in the game world
        Rigidbody2D bulletBody = Enemybullet.GetComponent<Rigidbody2D>();// create a rigid body on the laser and get the component
        bulletBody.AddForce(enemyfirePoint.up * bulletforce, ForceMode2D.Impulse);//add a force for the laser to "shoot"
    }
}
