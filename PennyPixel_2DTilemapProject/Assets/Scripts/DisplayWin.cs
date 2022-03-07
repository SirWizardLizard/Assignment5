/*
 * Zechariah Burrus
 * Assignment 5
 * Turns on win text when the trigger is entered and the score is 10 or greater
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayWin : MonoBehaviour
{
    private DisplayScore displayScore;
    public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        displayScore = GameObject.FindGameObjectWithTag("Score").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(displayScore.score >= 10) {
            winText.SetActive(true);
        }
    }
}
