using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ENWeapon : MonoBehaviour
{

    public GameObject bulletPrefab;

    public Transform bulletSpawn;

    public List<GameObject> Weapons;

  

    public float fireTime = 0.5f;

    private bool isFiring = false;

    public float timeRemaining = 10;

    private void Start()
    {
        int Weap = Random.Range(0, Weapons.Count);
        

        

    }
    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else if (timeRemaining <= 0) 
        {
            if (!isFiring) 
            {
                Fire();
                timeRemaining = 5;
            }
        }
    }
    



    private void Fire()
    {

        isFiring = true;


        Vector3 bulletPosition = bulletSpawn.position;


        Quaternion bulletRotation = bulletSpawn.rotation;


        Instantiate(bulletPrefab, bulletPosition, bulletRotation);



        if (GetComponent<AudioSource>() != null)
        {

            GetComponent<AudioSource>().Play();
        }



        Invoke("SetFiring", fireTime);
    }



    private void SetFiring()
    {
        isFiring = false;
    }
}
