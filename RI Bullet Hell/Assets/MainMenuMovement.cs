using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMovement : MonoBehaviour
{
    public GameObject Logo;
    public GameObject Pannel;

    public void LogoClicked()
    {
        Logo.GetComponent<Animator>().SetBool("Clicked", true);
    }
}
