using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcGen : MonoBehaviour
{

    public Transform[] Prefabs;

    public int NumofItems;

    float treeMap = Mathf.PerlinNoise(5, 5);

    public Object map;




    // Start is called before the first frame update
    void Start()
    {
        


        for (int i = 0; i < NumofItems; i++)
        {
            int ranSelect = Random.Range(0, Prefabs.Length);

            Vector3 spawnPoint = transform.position + new Vector3(0, 0, 8);

            Quaternion spawnRotation = Quaternion.identity;

            Instantiate(Prefabs[ranSelect], spawnPoint, spawnRotation);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
