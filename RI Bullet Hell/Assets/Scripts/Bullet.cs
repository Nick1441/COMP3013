using UnityEngine;

[RequireComponent(typeof(Rigidbody))]


public class Bullet : MonoBehaviour
{
    
    public float moveSpeed = 100;

    public int damage = 1;

    private void Start()
    {
        
        Vector3 facingDirection = transform.forward;

        Vector3 velocity = facingDirection * moveSpeed;

        GetComponent<Rigidbody>().AddForce(velocity);
    }


    private void OnTriggerEnter(Collider other)
    {
        string methodName = "TakeDamage";

        SendMessageOptions messageOptions = SendMessageOptions.DontRequireReceiver;

        Transform hitObject = other.transform;

        hitObject.SendMessage(methodName, damage, messageOptions);

        Die();
    }


    
    private void OnBecameInvisible()
    {
        Die();
    }

    private void Die()
    {
        
        Destroy(gameObject);
    }
}
