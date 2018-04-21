using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthScript : MonoBehaviour
{
    public ScoreScript scoreScript;
    public string player;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(player);
        if (collision.gameObject.tag.Equals("Food"))
        {
            scoreScript.addScore(player, 50);
            Destroy(collision.gameObject);
            Camera.main.gameObject.GetComponent<CameraShake>().Shake(0.3f);
        }
    }
}
