﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleedingSpot : MonoBehaviour
{
    public ParticleSystem BloodParticle;

    void Start()
    {
    }

    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D colider)
    {
        if (colider.gameObject.tag == "Fork")
        {
			AudioControl.Instance.playHurt ();
            BloodParticle.Play();
            if (transform.position.x < 0)
            {
                GameControl.Instance.ChangeScore(2, -5);
            }
            else if (transform.position.x > 0)
            {
                GameControl.Instance.ChangeScore(1, -5);
            }
			Camera.main.gameObject.GetComponent<CameraShake>().Shake(0.15f);
		}
    }
}
