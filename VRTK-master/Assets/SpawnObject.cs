using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {
    public Vector3 center;
    public Vector3 size;
    public GameObject foodPrefab;
    public int count;
    // Use this for initialization
    public float timer = 0f;
    public float spawnTime = 3f;


    void Start () {
        InvokeRepeating("SpawnFood", spawnTime, spawnTime);
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        
        /*
        if (count < 10) {
            SpawnFood();
        }
        */
    }

     void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center,size);
    }
    public void SpawnFood() {
        
        Vector3 pos = center +new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.z / 2, size.z / 2));
        count++;
        ScoreManager.spawnAmount += 1;
        Instantiate(foodPrefab,pos,Quaternion.identity);
    }

    public void MinusFood(){
        count--;
    }
}
 