/*
 * Zechariah Burrus
 * Assignment 4
 * Gem collision and destruction as well as score incrementation when a 2d collision happens.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemBehaviour : MonoBehaviour
{
	[Header("References")]
	public GameObject gemVisuals;
	public GameObject collectedParticleSystem;
	public CircleCollider2D gemCollider2D;

	private float durationOfCollectedParticleSystem;

    private DisplayScore displayScore;

	void Start()
	{
        displayScore = GameObject.FindGameObjectWithTag("Score").GetComponent<DisplayScore>();
        durationOfCollectedParticleSystem = collectedParticleSystem.GetComponent<ParticleSystem>().main.duration;
	}

	void OnTriggerEnter2D(Collider2D theCollider)
	{
		if (theCollider.CompareTag ("Player")) {
			GemCollected ();
            displayScore.score++;
        }
	}

	void GemCollected()
	{
		gemCollider2D.enabled = false;
		gemVisuals.SetActive (false);
		collectedParticleSystem.SetActive (true);
		Invoke ("DeactivateGemGameObject", durationOfCollectedParticleSystem);

	}

	void DeactivateGemGameObject()
	{
		gameObject.SetActive (false);
    }
}
