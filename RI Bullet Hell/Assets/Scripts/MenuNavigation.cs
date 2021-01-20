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
    public GameObject Crosshair;

    //Managing Controls UI
    public GameObject Pannel;
    public GameObject Pannel1;
    public GameObject Pannel2;
    public GameObject UI;
    public GameObject UIButton;

    //UI For Pause Menu & Bool for Paused Or Not
    public GameObject PauseMenu;
    public bool Paused = false;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        PauseMenu.SetActive(false);
        UI.SetActive(false);
        UIButton.SetActive(false);
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
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GameScreen()
    {
        PlayerPrefs.SetInt("ResetNo",0);
        SceneManager.LoadScene("Proc gen");
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Paused = false;
        Cursor.visible = false;
        
        Time.timeScale = 1;
        Player.GetComponent<SmoothMoveTest>().enabled = true;
        Weapon.GetComponent<WeaponManager>().enabled = true;
        Crosshair.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void Pause()
    {

        Crosshair.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Paused = true;
        Time.timeScale = 0;
        Player.GetComponent<SmoothMoveTest>().enabled = false;
        Weapon.GetComponent<WeaponManager>().enabled = false;
        PauseMenu.SetActive(true);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void EndScreen()
    {

    }

    public void DisplayControls()
    {
        Pannel.SetActive(false);
        Pannel2.SetActive(false);
        Pannel1.SetActive(false);
        UI.SetActive(true);
        UIButton.SetActive(true);
    }    

    public void CloseControls()
    {
        Pannel.SetActive(true);
        Pannel1.SetActive(true);
        Pannel2.SetActive(true);
        UI.SetActive(false);
        UIButton.SetActive(false);
    }
}
