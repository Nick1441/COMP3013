using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAP : MonoBehaviour
{
    public GameObject player;

    //public List<GameObject> Weapons;

    public float timeRemaining;
    
    public GameObject CurrWeapon;
    //Transform spawn;
    //int Weap;
    void Start()
    {
        timeRemaining = Random.Range(2, 8);
        
    }

    // Update is called once per frame
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
        CurrWeapon.GetComponent<Weapon>().startFire = true;
    }
    

   
}
