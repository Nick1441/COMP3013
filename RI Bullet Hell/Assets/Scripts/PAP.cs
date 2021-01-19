using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAP : MonoBehaviour
{
    public GameObject player;
    public float timeRemaining;
    public GameObject CurrWeapon;
    [SerializeField] float minFireRate = 0;
    [SerializeField] float maxFireRate = 5;
    void Start()
    {
        timeRemaining = Random.Range(2, 8);
        
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
            timeRemaining = Random.Range(2, 5);
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
