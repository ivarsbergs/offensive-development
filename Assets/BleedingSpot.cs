using System.Collections;
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
            this.BloodParticle.Play();
        }
    }
}
