using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int cherries;
    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        cherries = PlayerPrefs.GetInt("cherriesQuantity", 0);
        cherriesText.text = "Cherries: " + cherries;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
            PlayerPrefs.SetInt("cherriesQuantity", cherries);
            PlayerPrefs.Save();
        }
    }
}
