using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {
	private int player1Score = 0;
	private int player2Score = 0;
	public int maxScore = 2000;
	public GameObject player1UI;
	public GameObject player2UI;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addScore(string player, int score) {
		if (player.Equals("Player1")) {
			player1Score += score;
		}
		else if (player.Equals("Player2")) {
			player2Score += score;
		}
		player1UI.GetComponent<UnityEngine.UI.Text> ().text = ("Player 1: " + player1Score);
		player2UI.GetComponent<UnityEngine.UI.Text> ().text = ("Player 2: " + player2Score);
		Debug.Log ("Player 1 score: " + player1Score);
		Debug.Log ("Player 2 Score: " + player2Score);

		if (player1Score >= maxScore) {
			Debug.Log ("Player 1 Won!");
			player1UI.GetComponent<UnityEngine.UI.Text> ().text = ("Player 1 won!");
		} else if (player2Score >= maxScore) {
			player1UI.GetComponent<UnityEngine.UI.Text> ().text = ("Player 2 won!");
		}
	}
}
