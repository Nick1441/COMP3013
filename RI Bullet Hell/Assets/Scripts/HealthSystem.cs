
using UnityEngine;



using UnityEngine.Events;
using UnityEngine.SceneManagement;

[System.Serializable]

public class OnDamagedEvent : UnityEvent<int> { }

public class HealthSystem : MonoBehaviour
{

    [SerializeField] float health = 10;

    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;

    public AudioClip Damaged;
    public AudioClip Die;
    public AudioSource Saudio;

    public void TakeDamage(int damage)
    {

        health = health - damage;

        

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
