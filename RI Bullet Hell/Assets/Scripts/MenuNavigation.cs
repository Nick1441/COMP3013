using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuNavigation : MonoBehaviour
{
    //Disable Mouse Mousemovement & Weapon Switching When Paused
    public GameObject Player;
    public GameObject Weapon;

    //UI For Pause Menu & Bool for Paused Or Not
    public GameObject PauseMenu;
    public bool Paused = false;

    private void Start()
    {
        Cursor.visible = false;
        PauseMenu.SetActive(false);
    }

    void Update()
    {
        //Checking For Pause Menu On Main game
        if (SceneManager.GetActiveScene().name == "Proc gen")
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Paused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }

        //Issue With Mouse Disapearing On Paused? Might only be in Unity
        if (Paused)
        {
            Cursor.visible = true;
        }
        else 
        {
            Cursor.visible = false;
        }

    }
    
    void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void GameScreen()
    {
        SceneManager.LoadScene("Proc gen");
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
        Cursor.visible = false;
        Paused = false;
        Time.timeScale = 1;
        Player.GetComponent<SmoothMoveTest>().enabled = true;
        Weapon.GetComponent<WeaponManager>().enabled = true;
        PauseMenu.SetActive(false);
    }

    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Paused = true;
        Time.timeScale = 0;
        Player.GetComponent<SmoothMoveTest>().enabled = false;
        Weapon.GetComponent<WeaponManager>().enabled = false;
        PauseMenu.SetActive(true);
    }

}
