using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour {
	public GameObject sushi;
	private GameObject spawnedFood = null;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnedFood == null) {
			Vector3 newPos = new Vector3(Random.value*10-5, 10.0f );
			transform.position = newPos;
			spawnedFood = Instantiate (sushi, this.transform) as GameObject;
		}
		if (spawnedFood.transform.position.y < -6.0f || spawnedFood.transform.position.y > 12.0f || spawnedFood.transform.position.x < -13.0f || spawnedFood.transform.position.x > 13.0f) {
			Destroy (spawnedFood);
		}
	}
}