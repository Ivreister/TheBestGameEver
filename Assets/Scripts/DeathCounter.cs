using UnityEngine;
using UnityEngine.UI;

public class DeathCounter : MonoBehaviour
{

    [SerializeField] public int deathQuantity = 0;

    private void Start()
    {
        deathQuantity = PlayerPrefs.GetInt("deathQuantity", 0);
    }

    public void IncreasedeathQuantity()
    {
        deathQuantity++;

        PlayerPrefs.SetInt("deathQuantity", deathQuantity);
        PlayerPrefs.Save();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            IncreasedeathQuantity();
        }
    }
}

