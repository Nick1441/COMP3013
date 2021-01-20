using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lookAt;
    void Start()
    {
        if(lookAt == null)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPostition = new Vector3(lookAt.transform.position.x,
        this.transform.position.y,
        lookAt.transform.position.z);
        this.transform.LookAt(targetPostition);
    }
    public void addScore()
    {
        int Total = PlayerPrefs.GetInt("TotalEnemiesKilled");
        int Run = PlayerPrefs.GetInt("RunKills");
        Total++;
        Run++;
        PlayerPrefs.SetInt("TotalEnemiesKilled", Total);
        PlayerPrefs.SetInt("RunKills", Run);

    }
}
