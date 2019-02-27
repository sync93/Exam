using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING,WAITING,COUNTING};

    [System.Serializable]
    public class Wave {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;

    }
    public Wave[] waves;
    private int nextWave = 0;
    public float timeBetweenWaves = 5f;
    public float waveCountdown;

    private float searchCountdown = 1f;

    public SpawnState state = SpawnState.COUNTING;
    public int positionNumber = 0;
    public Transform[] spawnLocation;


    void Start() {
        waveCountdown = timeBetweenWaves;
    }
    void Update() {
        if (state == SpawnState.WAITING) {
            waveCountdown = timeBetweenWaves;
            state = SpawnState.COUNTING;
           
            nextWave++;

            //check if enemy are still alive
            if (!EnemyIsAlive()) {
                //begin new round
            }
            else
            {
                return;
            }
        }

        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                //start spawning
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else {
                   waveCountdown -= Time.deltaTime;
        }
       

    }
   bool EnemyIsAlive() {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
            return false;
            }

        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        state = SpawnState.SPAWNING;
        //spawn
        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(_wave.rate);
        }
        state = SpawnState.WAITING;
        yield break;
    }
    void SpawnEnemy(Transform _enemy) {
        //spawn enemy
        Instantiate(_enemy, spawnLocation[positionNumber].transform.position, Quaternion.Euler(0, 0, 0));

        Debug.Log("Spawning Enemy: " + _enemy.name);
        ScoreManager.spawnAmount += 1;
        positionNumber++;
        if (positionNumber >= 10)
        {
            positionNumber = 0;
        }

    }
}
