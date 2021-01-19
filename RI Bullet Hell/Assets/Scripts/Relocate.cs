using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relocate : MonoBehaviour
{
    public float time = 5;
    private float timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        float timeRemaining = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else if (timeRemaining <= 0)
        {
            transform.position = new Vector3(Random.Range(-35f, 35), Random.Range(-15f, 35), Random.Range(-35f, 35));
            timeRemaining = time;
        }
    }
}
