using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    private Vector3 direction;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(speed, 0, 0);
            direction = Vector3.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(-speed, 0, 0);
            direction = Vector3.left;
        }

        if (Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(0, 0, speed);
            direction = Vector3.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(0, 0, -speed);
            direction = Vector3.down;
        }
    }
}
