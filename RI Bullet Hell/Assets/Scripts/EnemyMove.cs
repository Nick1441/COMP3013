using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(CharacterController))]
public class EnemyMove : MonoBehaviour
{
    
    
    public float maxSpeed = 0.5f;
    Transform newPos;
    //Rigidbody rigidbody;

    CharacterController characterController;

    float Speed = 7.5f;
    void Start()
    {
        //characterController = GetComponent<CharacterController>();
        //rigidbody = GetComponent<Rigidbody>();
        newPos = transform;
        pickNewPos();
    }

    void FixedUpdate()
    {
        Speed = maxSpeed / Time.deltaTime;
        if(transform.position == newPos.position) 
        {
            pickNewPos();
        }
        else 
        {
            //rigidbody.MovePosition(newPos );
            transform.position = Vector3.MoveTowards(transform.position, newPos.position, Time.deltaTime * maxSpeed);
        }
        
    }
    public void pickNewPos() 
    {
        newPos.position = new Vector3(Random.Range(-5f, 5), 20, Random.Range(-5f, 5));
    }

}