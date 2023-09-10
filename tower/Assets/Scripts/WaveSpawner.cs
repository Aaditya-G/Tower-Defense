using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 20f;
    private float countdown = 0.01f;

    private int waveIndex = 0;

    public TextMeshProUGUI waveCountdownText;


    private float timeBetweenEnemy = 0.3f;

    void Update() {
        if(countdown <= 0f){
        {
            StartCoroutine(SpawnWave());
        }
          
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = string.Format("{0:00.00}" , countdown);
    }

    IEnumerator SpawnWave(){
            
        for (int i= 0 ; i<waveIndex ; i++ ){
            SpawnEnemy();
            yield return new WaitForSeconds(timeBetweenEnemy);
        }

         waveIndex++;
    
    }

    void SpawnEnemy(){
         if(enemyPrefab != null) Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        
    }
}
