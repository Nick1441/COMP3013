

using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    GameObject CurrWeapon;
    //public GameObject player;
    void Start()
    {
        ChangeWeapon(0);
    }

    public void ChangeWeapon(int index)
    {
        if (index < transform.childCount)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                if (i == index)
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                    CurrWeapon = transform.GetChild(i).gameObject;
                }
                else 
                {
                    transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }
        else 
        {
            
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    void FireGun()
    {
        
        if(Input.GetMouseButton(0) == false) { CurrWeapon.GetComponent<Weapon>().startFire = false; }

        CurrWeapon.GetComponent<Weapon>().startFire = true;
        



    }

    public void AddWeapon(GameObject prefab)
    {
        GameObject weapon = Instantiate(prefab, transform.position, transform.rotation, transform);

        ChangeWeapon(weapon.transform.GetSiblingIndex());
    }


    public double mouseData;
    public int WeapIndex = 0;
    private void Update()
    {
        //transform.rotation = GetComponentInParent<Transform>().rotation;
        CurrWeapon.transform.rotation = Camera.main.transform.rotation;
        if (Input.GetMouseButton(0)) { FireGun();  }
        

        mouseData = Input.GetAxis("Mouse ScrollWheel");
        
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            WeapIndex++;
            if (WeapIndex >= transform.childCount) WeapIndex = 0;
            ChangeWeapon(WeapIndex);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            WeapIndex++;
            if (WeapIndex >= transform.childCount) WeapIndex = 0;
            ChangeWeapon(WeapIndex);
        }

        
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            ChangeWeapon(0); 
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            ChangeWeapon(1); 
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeWeapon(2);
        }
    }
}
