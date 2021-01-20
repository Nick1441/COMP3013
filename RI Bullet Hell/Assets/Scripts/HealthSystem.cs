
using UnityEngine;



using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]

public class OnDamagedEvent : UnityEvent<int> { }

public class HealthSystem : MonoBehaviour
{

    [SerializeField] int health = 100;

    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;

    public AudioClip Damaged;
    public AudioClip Die;
    public AudioSource Saudio;

    public HealthBar healthBar;

    public void Start()
    {
        healthBar.SetMaxHealth(health);
        healthBar.SetHealth(health);
    }

    public void TakeDamage(int damage)
    {

        health = health - damage;
        healthBar.SetHealth(health);


        if (health <= 1)
        {
            Saudio.PlayOneShot(Die,0.5f);
            onDie.Invoke();
        }

        if(Damaged != null) 
        {
            Saudio.PlayOneShot(Damaged,0.2f);
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
