using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {

	private GameObject Play;
	// Alpha増減値(点滅スピード調整)
	private float _Step = 0.03f;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		this.Play = GameObject.Find("PlayButton");
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		// 現在のAlpha値を取得
		float toColor = this.Play.GetComponent<Image>().color.a;
		// Alphaが0 または 1になったら増減値を反転
		if (toColor < 0 || toColor > 1){
			_Step = _Step * -1;
		}
		// Alpha値を増減させてセット
		this.Play.GetComponent<Image>().color = new Color(255, 255, 255, toColor + _Step);
	}

	//　スタートボタンを押したら実行する
	public void GameStart() {
		audioSource.Play ();
		SceneManager.LoadScene ("GameScene");
	}

	public void GoTitle() {
		SceneManager.LoadScene("TopScene");
	}
}
