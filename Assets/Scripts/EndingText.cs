using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingText : MonoBehaviour
{
    public ItemCollector itemCollector;
    public DeathCounter deathCounter;
    [SerializeField] private Text DeathCounterText;

    void Start()
    {
        string cherrisValue = itemCollector.cherries.ToString();
        string deathValue = deathCounter.deathQuantity.ToString();

        DeathCounterText.text = 
            "You have died " + deathValue + " times in this game and collected " 
            + cherrisValue + " cherris out of 69 possible.";
    }
    
}
