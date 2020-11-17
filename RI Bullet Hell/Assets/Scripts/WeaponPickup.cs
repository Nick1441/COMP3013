

using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public GameObject weaponPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        WeaponManager weaponManager = other.gameObject.GetComponentInChildren<WeaponManager>();

        if (weaponManager != null) 
        {
            weaponManager.AddWeapon(weaponPrefab);

            Destroy(gameObject);
        }
    }
}
