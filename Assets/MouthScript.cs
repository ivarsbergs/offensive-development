using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthScript : MonoBehaviour
{
    public string player;

    void Start()
    {
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Food"))
        {
			this.GetComponent<ParticleSystem>().Play();
            int player = this.gameObject.layer == LayerMask.NameToLayer("Head1") ? 2 : 1;
			if (player == 2) {
				AudioControl.Instance.manEat ();
			} else if (player == 1) {
				AudioControl.Instance.womanEat ();
			}
            GameControl.Instance.ChangeScore(player, 50);
            Destroy(collision.gameObject);
            Camera.main.gameObject.GetComponent<CameraShake>().Shake(0.3f);
        }
    }
}