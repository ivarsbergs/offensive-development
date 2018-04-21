using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {
	private int player1Score = 0;
	private int player2Score = 0;
	public int maxScore = 2000;
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
		Debug.Log ("Player 1 score: " + player1Score);
		Debug.Log ("Player 2 Score: " + player2Score);

		if (player1Score >= maxScore) {
			Debug.Log ("Player 1 Won!");
		} else if (player2Score >= maxScore) {
			Debug.Log ("Player 2 Won!");
		}
	}
}
