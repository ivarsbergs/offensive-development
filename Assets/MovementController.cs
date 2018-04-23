using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public string inputHorizontal;
    public string inputVertical;
    private float movementHorizontal;
    private float movementVertical;
    private int speed = 1000;
    private float jitterAmount = 0f;
    private float velocity;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        if (Input.GetAxis(inputVertical) == -1.0 && inputVertical.Equals("Vertical2"))
        {
            inputVertical = "Vertical2PS3";
            inputHorizontal = "Horizontal2PS3";
        }
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameControl.Instance.GameOver)
        {
            if (Random.value < 0.5d)
            {
                movementHorizontal = Input.GetAxis(inputHorizontal) + Random.value * jitterAmount;
            }
            else
            {
                movementHorizontal = Input.GetAxis(inputHorizontal) - Random.value * jitterAmount;
            }
            if (Random.value < 0.5d)
            {
                movementVertical = Input.GetAxis(inputVertical) + Random.value * jitterAmount;
            }
            else
            {
                movementVertical = Input.GetAxis(inputVertical) - Random.value * jitterAmount;
            }
            if (!GameControl.Instance.Moved)
            {
                GameControl.Instance.Moved = movementHorizontal != 0 || movementVertical != 0;
                if (GameControl.Instance.Moved)
                {
                    GameControl.Instance.Tutorial.gameObject.SetActive(false);
                }
            }
            Vector2 movementDirection = new Vector2(movementHorizontal, movementVertical);
            rb.velocity = movementDirection * speed * Time.deltaTime;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
