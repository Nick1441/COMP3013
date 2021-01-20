using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 30;
    public GameObject LaserSplash;
    private float degrees = 5;
    Vector3 to;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        to = to + new Vector3(degrees, 0, 0);

        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
    }
    private void OnCollisionEnter(Collision other)
    {
        string methodName = "GiveHealth";

        SendMessageOptions messageOptions = SendMessageOptions.DontRequireReceiver;

        Transform hitObject = other.transform;

        hitObject.SendMessage(methodName, health, messageOptions);

        SpawnDie();
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
