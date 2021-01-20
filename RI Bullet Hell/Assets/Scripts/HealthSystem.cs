
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
    public AudioClip GetHealth;
    public AudioSource Saudio;

    public HealthBar healthBar;

    public void Start()
    {
        if(gameObject.tag == "Enemy") 
        {
            health = health + (10 * PlayerPrefs.GetInt("ResetNo"));
        }
        if (healthBar != null)
        {
            healthBar.SetMaxHealth(health);
            healthBar.SetHealth(health);
        }

    }

    public void TakeDamage(int damage)
    {

        health = health - damage;
        if (healthBar != null)
        {
            healthBar.SetHealth(health);
        }

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
    public void getHP(int hp) 
    {
        health = health + hp;
        if (healthBar != null)
        {
            healthBar.SetHealth(health);
        }
        Saudio.PlayOneShot(GetHealth, 0.5f);
    }

    public void gameOver() 
    {
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
        SceneManager.LoadScene("End Screen");
        Time.timeScale = 1;
    }
    public void enemyDie() 
    {
        Destroy(gameObject);
    }
    
}
