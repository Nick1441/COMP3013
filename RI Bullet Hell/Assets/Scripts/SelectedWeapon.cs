using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedWeapon : MonoBehaviour
{
    public GameObject Weapons;
    public Text text;

    void Update()
    {
        for (int i = 0; i < Weapons.gameObject.transform.childCount; i++)
        {
            if (Weapons.gameObject.transform.GetChild(i).gameObject.activeSelf == true)
            {
                text.text = Weapons.gameObject.transform.GetChild(i).name;
            }
        }
    }
}
