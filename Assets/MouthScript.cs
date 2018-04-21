using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthScript : MonoBehaviour {
	GameObject scoreScript;
	public string player;
	GameObject cameraParent;
	// Use this for initialization
	void Start () {
		cameraParent = GameObject.Find ("CameraParent");
		scoreScript = GameObject.Find ("ScoreKeeper");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D collision) {
		Debug.Log (player);
		if (collision.gameObject.tag.Equals("Food")) {
			scoreScript.GetComponent<ScoreScript>().addScore (player, 50);
			Destroy (collision.gameObject);
			cameraParent.GetComponent<CameraShake> ().ShakeCamera(20.0f, 2.0f);
		}
	}
}
