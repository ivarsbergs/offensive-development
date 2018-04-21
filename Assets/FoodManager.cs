using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour {
	public GameObject food;
	private GameObject spawnedFood = null;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnedFood == null) {
			Vector3 newPos = new Vector3(Random.value*10-5, 10.0f );
			transform.position = newPos;
			spawnedFood = Instantiate (food, this.transform) as GameObject;
			spawnedFood.GetComponent<Rigidbody2D> ().AddTorque (Random.value*250);
		}
		if (spawnedFood.transform.position.y < -10.0f || spawnedFood.transform.position.y > 12.0f || spawnedFood.transform.position.x < -17.0f || spawnedFood.transform.position.x > 17.0f) {
			Destroy (spawnedFood);
		}
	}
}