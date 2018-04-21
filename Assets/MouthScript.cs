using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthScript : MonoBehaviour {
	public ScoreScript scoreScript;
	public string player;
	GameObject cameraParent;
	// Use this for initialization
	void Start () {
		cameraParent = GameObject.Find ("CameraParent");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D collision) {
		Debug.Log (player);
		if (collision.gameObject.tag.Equals("Food")) {
			scoreScript.addScore (player, 50);
			Destroy (collision.gameObject);
			cameraParent.GetComponent<CameraShake> ().ShakeCamera(0.5f,0.25f);
		}
	}
}
