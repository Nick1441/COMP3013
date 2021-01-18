using UnityEngine;

[RequireComponent(typeof(Rigidbody))]


public class Bullet : MonoBehaviour
{

    public GameObject LaserSplash;
    public float moveSpeed = 100;

    public int damage = 1;

    public float timeRemaining = 3;
    private void Start()
    {
        
        Vector3 facingDirection = transform.forward;

        Vector3 velocity = facingDirection * moveSpeed;

        GetComponent<Rigidbody>().AddForce(velocity);
    }

    

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else if (timeRemaining <= 0)
        {
            Die();
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string methodName = "TakeDamage";

        SendMessageOptions messageOptions = SendMessageOptions.DontRequireReceiver;

        Transform hitObject = other.transform;

        hitObject.SendMessage(methodName, damage, messageOptions);

        SpawnDie();
        //Die();
    }



    private void OnBecameInvisible()
    {
        Die();
    }

    private void Die()
    {
        
        Destroy(gameObject);
    }

    private void SpawnDie()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
        Vector3 NewSplash = this.transform.position;
        NewSplash.x = NewSplash.x = 0.0f;

        GameObject LaserDeath = Instantiate(LaserSplash, this.transform.position + (Camera.main.transform.forward / 6), Quaternion.identity);
        Destroy(gameObject);

        ParticleSystem Parts = LaserDeath.GetComponent<ParticleSystem>();
        float Duration = Parts.duration + Parts.startLifetime;


        Destroy(LaserDeath, Duration);
    }
}
