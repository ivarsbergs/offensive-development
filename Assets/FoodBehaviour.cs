using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<ParticleSystem>().Play();
		Debug.Log (collision.gameObject.tag);
		if (collision.gameObject.tag == "Fork") {
			AudioControl.Instance.forkBounce ();
		} else {
			AudioControl.Instance.headBounce ();
		}
    }
}
