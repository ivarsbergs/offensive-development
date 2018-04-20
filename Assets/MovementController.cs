using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
	private int speed = 300;
	private float velocity;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 movementDirection = new Vector2 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		Debug.Log (movementDirection);
		rb.velocity = movementDirection * speed * Time.deltaTime;
	}
}
