﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkClash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter2D (Collider2D collider) {
		AudioControl.Instance.forkClash ();
		Debug.Log ("Clashed!");
	}
}
