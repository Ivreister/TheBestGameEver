using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{   
    private Rigidbody2D rigidBody;
    private Animator animator;

    [SerializeField] private AudioSource deathAudioEffect;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap")) 
        {
            Die();
        }
    }
    private void Die()
    {
        deathAudioEffect.Play();
        rigidBody.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("death");
        
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
