using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleedingSpot : MonoBehaviour
{
	GameObject scoreScript;
    public ParticleSystem BloodParticle;

    void Start()
    {
		scoreScript = GameObject.Find ("ScoreKeeper");
    }

    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D colider)
    {
        if (colider.gameObject.tag == "Fork")
        {
			BloodParticle.Play();
			if (transform.position.x < 0) {
				scoreScript.GetComponent<ScoreScript> ().removeScore ("Player2", 5);
			} else if (transform.position.x > 0) {
				scoreScript.GetComponent<ScoreScript> ().removeScore ("Player1", 5);
			}
        }
    }
}
