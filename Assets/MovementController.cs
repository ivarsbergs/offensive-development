using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
	public string inputHorizontal;
	public string inputVertical;
	private float movementHorizontal;
	private float movementVertical;
	private int speed = 300;
	private float velocity;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.value < 0.5d) {
			movementHorizontal = Input.GetAxis (inputHorizontal) + Random.value * 0.3f;
		} else {
			movementHorizontal = Input.GetAxis (inputHorizontal) - Random.value * 0.3f;
		}
		if (Random.value < 0.5d) {
			movementVertical = Input.GetAxis (inputVertical) + Random.value * 0.3f;
		} else {
			movementVertical = Input.GetAxis (inputVertical) - Random.value * 0.3f;
		}
		Debug.Log (movementHorizontal);
		Debug.Log(movementVertical);
		Vector2 movementDirection = new Vector2 (movementHorizontal, movementVertical);

		rb.velocity = movementDirection * speed * Time.deltaTime;
	}
}
