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
        Debug.Log("Enter before check!" + colider.gameObject.tag);
        if (colider.gameObject.tag == "Fork")
        {
            Debug.Log("Enter!");
            this.BloodParticle.Play();
        }
    }
}
