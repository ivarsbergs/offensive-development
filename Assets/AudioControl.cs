using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {
	public static AudioControl Instance;
	public AudioClip blood1;
	public AudioClip blood2;
	public AudioClip blood3;
	public AudioClip stab1;
	public AudioClip stab2;
	public AudioClip stab3;
	public AudioClip stab4;
	public AudioClip foodSpawn;
	public AudioClip foodDeSpawn;
	public AudioClip forks1;
	public AudioClip forks2;
	public AudioClip forks3;
	public AudioClip man1;
	public AudioClip man2;
	public AudioClip man3;
	public AudioClip man4;
	public AudioClip woman1;
	public AudioClip woman2;
	public AudioClip woman3;
	public AudioClip bounce1;
	public AudioClip bounce2;
	public AudioClip bounce3;
	public AudioClip bounce4;
	public AudioClip bounce5;
	private AudioSource audioSource; 
	private float veryLowVolume = 0.2f;
	private float lowVolume = 0.5f;
	private float mediumVolume = 0.7f;
	private float highVolume = 1.0f;

	void Awake() {
		Instance = this;
	}
	// Use this for initialization
	void Start () {
		audioSource = this.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void playHurt() {
		int bloodSound = Random.Range (0, 2);
		int stabSound = Random.Range (0, 3);
		if (bloodSound == 0) {
			audioSource.PlayOneShot (blood1, lowVolume);
		} else if (bloodSound == 1) {
			audioSource.PlayOneShot (blood2, lowVolume);
		} else if (bloodSound == 2) {
			audioSource.PlayOneShot (blood3, lowVolume);
		}
		if (stabSound == 0) {
			audioSource.PlayOneShot (stab1, lowVolume);
		} else if (stabSound == 1) {
			audioSource.PlayOneShot (stab2, lowVolume);
		} else if (stabSound == 2) {
			audioSource.PlayOneShot (stab3, lowVolume);
		} else if (stabSound == 3) {
			audioSource.PlayOneShot (stab4, lowVolume);
		}
	}
	public void playFood() {
		audioSource.PlayOneShot (foodSpawn, highVolume);
	}
	public void forkClash() {
		int forkSound = Random.Range (0, 2);
		if (forkSound == 0) {
			audioSource.PlayOneShot (forks1, lowVolume);
		} else if (forkSound == 1) {
			audioSource.PlayOneShot (forks2, lowVolume);
		} else if (forkSound == 2) {
			audioSource.PlayOneShot (forks3, lowVolume);
		}
	}
	public void manEat() {
		int eatSound = Random.Range (0, 3);
		if (eatSound == 0) {
			audioSource.PlayOneShot (man1, mediumVolume);
		} else if (eatSound == 1) {
			audioSource.PlayOneShot (man2, mediumVolume);
		} else if (eatSound == 2) {
			audioSource.PlayOneShot (man3, mediumVolume);
		} else if (eatSound == 3) {
			audioSource.PlayOneShot (man4, mediumVolume);
		}
	}
	public void womanEat() {
		int eatSound = Random.Range (0, 2);
		if (eatSound == 0) {
			audioSource.PlayOneShot (woman1, mediumVolume);
		} else if (eatSound == 1) {
			audioSource.PlayOneShot (woman2, mediumVolume);
		} else if (eatSound == 2) {
			audioSource.PlayOneShot (woman3, mediumVolume);
		}
	}
	public void forkBounce() {
		int forkSound = Random.Range (0, 4);
		if (forkSound == 0) {
			audioSource.PlayOneShot (bounce1, mediumVolume);
		} else if (forkSound == 1) {
			audioSource.PlayOneShot (bounce2, mediumVolume);
		} else if (forkSound == 2) {
			audioSource.PlayOneShot (bounce3, mediumVolume);
		} else if (forkSound == 3) {
			audioSource.PlayOneShot (bounce4, mediumVolume);
		} else if (forkSound == 4) {
			audioSource.PlayOneShot (bounce5, mediumVolume);
		}
	}
	public void deSpawnFood() {
		audioSource.PlayOneShot (foodDeSpawn, veryLowVolume);
	}
}
