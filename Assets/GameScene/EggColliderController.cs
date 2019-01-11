using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EggColliderController : MonoBehaviour {

	private AudioSource audioSource;
	public AudioClip audioClip1;
	public AudioClip audioClip2;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y <= 0.5) {
			Invoke("GameOver", 0.4f);
			audioSource.clip = audioClip2;
			audioSource.Play ();
		}
	}

	void OnCollisionEnter(Collision other) {
		if (gameObject.tag == other.gameObject.tag) {
			audioSource.clip = audioClip1;
			audioSource.Play ();
			other.transform.localScale = new Vector3 (162f, 162f, 162f);
		} else if (other.gameObject.tag == "RainbowEgg") {
			audioSource.clip = audioClip1;
			audioSource.Play ();
			this.gameObject.transform.localScale = new Vector3 (162f, 162f, 162f);
		}
	}


	void GameOver() {
		SceneManager.LoadScene("EndScene");
	}

}