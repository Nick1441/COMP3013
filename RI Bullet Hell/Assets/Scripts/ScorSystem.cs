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
        
    }
}
