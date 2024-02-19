using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedItemsExistence : MonoBehaviour
{
    private string collectedKey;

    void Start()
    {
        collectedKey = "cherryCollected_" + transform.position.ToString();

        if (PlayerPrefs.GetInt(collectedKey, 0) == 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt(collectedKey, 1);
            PlayerPrefs.Save();
        }
    }

}
