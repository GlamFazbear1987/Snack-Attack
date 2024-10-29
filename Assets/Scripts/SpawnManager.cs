using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Randomly generated animal index and spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0 spawnPosZ);
            int  foodIndex = Random.Range(0 foodPrefabs.Length);
            Instantiate.(foodPrefabs[foodIndex], spawnPos, foodPrefabs[foodIndex].transform.rotatoin);
        }
    }
}
