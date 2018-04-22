using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl Instance;
    public bool GameOver;
    public bool Moved;
    public int MaxScore = 150;
    public int Player1Score = 0;
    public int Player2Score = 0;
    private GameObject spawnedFood;
    public UnityEngine.UI.Text Player1ScroreText;
    public UnityEngine.UI.Text Player2ScroreText;
    public GameObject GameOverPanel;
    public UnityEngine.UI.Text WinnerText;
    public GameObject FoodPrefab;
    public UnityEngine.UI.Image Player1HitpointsFill;
    public UnityEngine.UI.Image Player2HitpointsFill;
    public GameObject Tutorial;

    void Awake()
    {
        Instance = this;
        this.spawnedFood = null;
        this.GameOver = false;

        Invoke("ShowTutorial", 5f);
    }

    void Start()
    {
    }

    void Update()
    {
        if (this.spawnedFood == null && !this.GameOver)
        {
            this.spawnFood();
        }
        else if (this.spawnedFood != null && (this.spawnedFood.transform.position.y < -14.0f || this.spawnedFood.transform.position.y > 12.0f || this.spawnedFood.transform.position.x < -30.0f || this.spawnedFood.transform.position.x > 30.0f))
        {
            Destroy(this.spawnedFood, 1.0f);
            if (!this.GameOver)
            {
                this.spawnFood();
            }
        }
        if (this.GameOver && Input.GetKeyDown(KeyCode.Space))
        {
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
    }

    public void ChangeScore(int player, int delta)
    {
        if (player == 1)
        {
            this.Player1Score += delta;
            if (this.Player1Score >= this.MaxScore)
            {
                this.Player1Score = this.MaxScore;
                this.GameOverPanel.SetActive(true);
                this.GameOver = true;
                this.WinnerText.text = "PLAYER 1 WON";
            }
            else if (this.Player1Score < 0)
            {
                this.Player1Score = 0;
            }
            this.Player1ScroreText.text = "" + (this.MaxScore - this.Player1Score);
            float fill = (this.MaxScore - this.Player1Score) / (float)this.MaxScore;
            this.Player1HitpointsFill.fillAmount = fill;
        }
        else if (player == 2)
        {
            this.Player2Score += delta;
            if (this.Player2Score >= this.MaxScore)
            {
                this.Player1Score = this.MaxScore;
                this.GameOverPanel.SetActive(true);
                this.GameOver = true;
                this.WinnerText.text = "PLAYER 2 WON";
            }
            else if (this.Player2Score < 0)
            {
                this.Player2Score = 0;
            }
            this.Player2ScroreText.text = "" + (this.MaxScore - this.Player2Score);
            float fill = (this.MaxScore - this.Player2Score) / (float)this.MaxScore;
            this.Player2HitpointsFill.fillAmount = fill;
        }
    }
    private void spawnFood()
    {
        Vector3 newPos = new Vector3(Random.value * 10 - 5, 10.0f);
        transform.position = newPos;
        this.spawnedFood = Instantiate(this.FoodPrefab, this.transform) as GameObject;
        this.spawnedFood.GetComponent<Rigidbody2D>().AddTorque(Random.value * 250);
    }

    public void ShowTutorial()
    {
        if (!Moved)
        {
            this.Tutorial.gameObject.SetActive(true);
        }
    }
}
