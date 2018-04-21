using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
	public string inputHorizontal;
	public string inputVertical;
	private float movementHorizontal;
	private float movementVertical;
	private int speed = 600;
	private float jitterAmount = 0.15f;
	private float velocity;
	private Rigidbody2D rb;
	private Vector2 movementDirection;

	// Use this for initialization
	void Start () {
		Debug.Log (Input.GetAxis (inputVertical));
		if (Input.GetAxis (inputVertical) == -1.0 && inputVertical.Equals ("Vertical2")) {
			inputVertical = "Vertical2PS3";
			inputHorizontal = "Horizontal2PS3";
		}
		rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.value < 0.5d) {
			movementHorizontal = Input.GetAxis (inputHorizontal) + Random.value * jitterAmount;
		} else {
			movementHorizontal = Input.GetAxis (inputHorizontal) - Random.value * jitterAmount;
		}
		if (Random.value < 0.5d) {
			movementVertical = Input.GetAxis (inputVertical) + Random.value * jitterAmount;
		} else {
			movementVertical = Input.GetAxis (inputVertical) - Random.value * jitterAmount;
		}

		/*
		if ((transform.position.x > 6.0f && movementHorizontal > 0) || (transform.position.x < -8.0f && movementHorizontal < 0)) {
			if (Random.value < 0.5d) {
				movementHorizontal = Random.value * jitterAmount;
			} else {
				movementHorizontal = Random.value * -jitterAmount;
			}
			movementDirection = new Vector2 (movementHorizontal, movementVertical);
		} else if ((transform.position.y > 5.0f && movementVertical > 0)|| (transform.position.y < -12.0f && movementVertical < 0)) {
			if (Random.value < 0.5d) {
				movementVertical = Random.value * jitterAmount;
			} else {
				movementVertical = Random.value * -jitterAmount;
			}
			movementDirection = new Vector2 (movementHorizontal, movementVertical);
		} else {
			movementDirection = new Vector2 (movementHorizontal, movementVertical);
		}
		*/
		movementDirection = new Vector2 (movementHorizontal, movementVertical);
		rb.velocity = movementDirection * speed * Time.deltaTime;
	}
}
