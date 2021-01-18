using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ RequireComponent(typeof(Collider))]
public class CoverCubes : MonoBehaviour
{
    // Start is called before the first frame update
    Collider Col;
    
    void Start()
    {
        Col = GetComponent<Collider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Cover") 
        {
            Destroy(gameObject);
        }
    }
    
}
