using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAP : MonoBehaviour
{
    public GameObject player;
    public float timeRemaining = 5;
    public GameObject CurrWeapon;
    [SerializeField] float minFireRate = 0;
    [SerializeField] float maxFireRate = 5;
    void Start()
    {
        timeRemaining = Random.Range(minFireRate, maxFireRate);
        
    }

    
    void Update()
    {
        transform.LookAt(player.transform);

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else if (timeRemaining <= 0)
        {
            FireGun();
            timeRemaining = Random.Range(minFireRate, maxFireRate);
        }
        

    }
   
    
    void FireGun()
    {
        if (CurrWeapon != null)
        {
            CurrWeapon.GetComponent<Weapon>().startFire = true;
        }
    }

    
    

   
}
