using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    public GameObject bulletPrefab;
    //public GameObject player;
    public Transform bulletSpawn;
    
    public float fireTime = 0.5f;

    public bool isFiring = false;

    public bool startFire = false;

    private void Update()
    {
        
        gameObject.transform.rotation = GetComponentInParent<Transform>().transform.rotation;
        if (!isFiring)
            {
            
                if (startFire == true) {  Fire();  }
                startFire = false;
        }
        
    }


    
    private void Fire()
    {
        isFiring = true;

        Vector3 bulletPosition = bulletSpawn.position;

        Quaternion bulletRotation = bulletSpawn.rotation;

        Invoke("SetFiring", fireTime);

        Instantiate(bulletPrefab, bulletPosition, bulletRotation);

        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
        
    }


    
    private void SetFiring()
    {
        isFiring = false;
    }
} 
