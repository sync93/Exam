using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  public float timer = 0f;
    public float spawnTime = 3f;
    public int positionNumber = 0;
    public Transform[] spawnLocation;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;
  
    // Start is called before the first frame update


    void Start()
    {
        InvokeRepeating("spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

      
    }
    void spawn() {
        whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0],spawnLocation[positionNumber].transform.position,Quaternion.Euler(0,0,0))as GameObject;
        ScoreManager.spawnAmount += 1;
        positionNumber++;
        if (positionNumber >= 10) {
            positionNumber = 0;
        }
    }
}
