using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScorSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("ResetNo"));
        PlayerPrefs.SetInt("RunKills", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0) 
        {
            int x = PlayerPrefs.GetInt("ResetNo");
            x++;
            PlayerPrefs.SetInt("ResetNo", x);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            PlayerPrefs.SetInt("ResetNo", 0);
            Debug.Log(PlayerPrefs.GetInt("ResetNo"));
        }
        
    }
}
