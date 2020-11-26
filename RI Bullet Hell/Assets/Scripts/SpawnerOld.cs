using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOld : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawn;
    private Transform SpawnLoc;
    public float Spawntime = 5;
    public int maxSpawn;
    public Vector3 spawnArea;
    float x, y, z;



    void Start()
    {
        SpawnLoc = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Spawntime <= 0) 
        {
            if (transform.childCount < maxSpawn)
            {
                x = Random.Range(transform.position.x, transform.position.x + spawnArea.x);
                y = Random.Range(transform.position.y, transform.position.y + spawnArea.y);
                z = Random.Range(transform.position.z, transform.position.z + spawnArea.z);
                SpawnLoc.position = SpawnLoc.position + new Vector3(x, y, z);
                Instantiate(spawn, SpawnLoc);
                Spawntime = 5;
            }
            Spawntime = 5;
        }
        Spawntime -= Time.deltaTime;
    }
}
