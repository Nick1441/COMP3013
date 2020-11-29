using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgileJumpReset : MonoBehaviour
{

    public GameObject Player;
    public Vector3 MyNewPos;

    private void OnTriggerStay(Collider other)
    {
        CharacterController CC = Player.GetComponent<CharacterController>();
        CC.enabled = false;
        MyNewPos.Set(8, 1.08f, 3.5f);
        Player.transform.position = MyNewPos;
        Player.transform.rotation = Quaternion.Euler(0, 90, 0);
        CC.enabled = true;


    }
}
