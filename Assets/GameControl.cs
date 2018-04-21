using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl Instance;
    public bool Running = true;
    public int MaxScore = 150;
    public int Player1Score = 0;
    public int Player2Score = 0;
    public UnityEngine.UI.Text Player1ScroreText;
    public UnityEngine.UI.Text Player2ScroreText;
    public GameObject GameOver;
    public UnityEngine.UI.Text WinnerText;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
    }

    void Update()
    {
    }

    public void ChangeScore(int player, int delta)
    {
        if (player == 1)
        {
            this.Player1Score += delta;
            this.Player1ScroreText.text = "Player 1: " + this.Player1Score;
            if (this.Player1Score >= this.MaxScore)
            {
                //TODO show game over
            }
        }
        else if (player == 2)
        {
            this.Player2Score += delta;
            this.Player2ScroreText.text = "Player 2: " + this.Player2Score;
            if (this.Player2Score >= this.MaxScore)
            {
                //TODO show game over
            }
        }
    }
}
