using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform FowT;
    private Rigidbody rb;
    private Vector3 FowVector = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = FowT.forward * Time.deltaTime * 200;
    }
}
