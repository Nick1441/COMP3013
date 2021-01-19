using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    void Update()
    {
        Vector3 MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z));

        Vector3 NewPos = Camera.main.ScreenToWorldPoint(MousePos);

        transform.position = NewPos;
    }
}
