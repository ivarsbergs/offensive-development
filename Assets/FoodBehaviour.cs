using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{	
	void Start() {
		this.GetComponent<ParticleSystem> ().Play();
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<ParticleSystem>().Play();
		if (collision.gameObject.tag == "Fork") {
			AudioControl.Instance.forkBounce ();
		} else {
			AudioControl.Instance.headBounce ();
		}
    }
}
