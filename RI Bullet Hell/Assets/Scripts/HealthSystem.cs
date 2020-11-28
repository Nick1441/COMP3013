
using UnityEngine;



using UnityEngine.Events;
using UnityEngine.SceneManagement;

[System.Serializable]

public class OnDamagedEvent : UnityEvent<int> { }

public class HealthSystem : MonoBehaviour
{

    public int health = 10;

    public UnityEvent onDie;

    public OnDamagedEvent onDamaged;

    public void TakeDamage(int damage)
    {
        
        health -= damage;

        onDamaged.Invoke(health);

        if (health < 1)
        {
            //Destroy(gameObject);
            onDie.Invoke();
        }
    }

    public void gameOver() 
    {
        if (GetComponent<AudioSource>() != null)
        {

            GetComponent<AudioSource>().Play();
        }
        SceneManager.LoadScene("SampleScene");
    }
    public void enemyDie() 
    {
        Destroy(gameObject);

    }
}
