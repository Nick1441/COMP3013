using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ResetScene()
    {
        SceneManager.LoadScene("Agile Course");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            SceneManager.LoadScene("Agile Course");
        }

        if (Input.GetKeyDown("l"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
