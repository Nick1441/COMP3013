using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAP : MonoBehaviour
{
    // GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];

    public GameObject player;

    public List<GameObject> Weapons;

    public float timeRemaining = Random.Range(2, 8);
    public float SwitchTime = 2;
    GameObject CurrWeapon;
    Transform spawn;
    int Weap;
    
    // Start is called before the first frame update
    void Start()
    {
        FindPlayer("Player");
        SpawnGun();

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
   
    void SpawnGun() 
    {
        if (CurrWeapon)
        {
            Destroy(CurrWeapon);
        }
        Weap = Random.Range(0, Weapons.Count);
        spawn = GetComponentInParent<Transform>();
        spawn.forward = spawn.forward * 2;
        CurrWeapon = Instantiate(Weapons[Weap], spawn);
        
        
        
    }
    void FireGun()
    {

        //Equiped = GetComponentInChildren<Weapon>();
        CurrWeapon.GetComponent<Weapon>().startFire = true;

        //Equiped

    }
    

    GameObject FindPlayer(string Player)
    {
        player = GameObject.Find(Player);
        return player;
    }
}
