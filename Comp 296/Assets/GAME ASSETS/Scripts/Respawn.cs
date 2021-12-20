using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public Transform SpawnPoint;
    public GameObject EnemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RespawnTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RespawnTimer()
    {
        SpawnEnemy();
        yield return new WaitForSeconds(10);
        Start();
    }

    void SpawnEnemy()
    {
        Instantiate(EnemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
        
    }


}
