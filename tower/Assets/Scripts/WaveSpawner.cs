using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 3f;

    private int waveIndex = 0;

    private float timeBetweenEnemy = 0.3f;

    void Update() {
        if(countdown <= 0f){
            if(enemyPrefab != null)
{
      StartCoroutine(SpawnWave());
}
          
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave(){
             waveIndex++;
        for (int i= 0 ; i<waveIndex ; i++ ){
            SpawnEnemy();
            yield return new WaitForSeconds(timeBetweenEnemy);
        }
    
    }

    void SpawnEnemy(){
         if(enemyPrefab != null) Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        
    }
}
