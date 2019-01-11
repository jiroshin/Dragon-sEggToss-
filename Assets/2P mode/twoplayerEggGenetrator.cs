using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class twoplayerEggGenetrator : MonoBehaviour {

	//RedBallPrefabを入れるためのゲームオブジェクトを作っておこう
	public GameObject BlueEggPrefab;
	public GameObject OrangeEggPrefab;

	private int num;
	public static int Eggnumber;

	private float bulletPower = 80f;

	//クリックした場所を入れるための変数も宣言するよ
	private Vector3 clickPosition;

	private GameObject scoreText;
	private GameObject FinePlayText;

	public Sprite BlueEgg;
	public Sprite OrangeEgg;
	public Image FirstImage;
	public Image SecondImage;


	private AudioSource audioSource;
	public AudioClip audioClip1;
	public AudioClip audioClip2;



	// Use this for initialization
	void Start () {
		num = 1;
		Eggnumber = 0;

		this.scoreText = GameObject.Find("ScoreText");
		this.FinePlayText = GameObject.Find("FinePlayText");
		this.scoreText.GetComponent<Text> ().text = "0 egg" ;

		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		//スクリーンの高さを取得して3分の１以上のとこ
		int height = Screen.height/3;
		//クリックした場所
		clickPosition = Input.mousePosition;
		//クリックしたところの高さ
		int click_height = Mathf.FloorToInt(clickPosition.y);


		//左クリックをしたとき
		if ( click_height > height && Input.GetMouseButtonDown (0) && Eggnumber < 97) {
			audioSource.clip = audioClip1;
			audioSource.Play ();

			//今のままではクリックした場所(手前)にボールが落ちてしまうので奥の方向(Z軸側)にPrefabのインスタンスを作る位置をズラす
			clickPosition.z = 4f;

			//インスタンス生成の向きをランダムにする
			BlueEggPrefab.transform.rotation = Random.rotation;

			//カメラ正面の向き
			Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

			if ( num % 2 == 1) {
				GameObject Egg = Instantiate(BlueEggPrefab, Camera.main.ScreenToWorldPoint (clickPosition),  BlueEggPrefab.transform.rotation);
				Egg.GetComponent<Rigidbody> ().AddForce (cameraForward*bulletPower);

			} else if ( num % 2 == 0 ) {
				GameObject Egg = Instantiate (OrangeEggPrefab, Camera.main.ScreenToWorldPoint (clickPosition), BlueEggPrefab.transform.rotation);
				Egg.GetComponent<Rigidbody> ().AddForce (cameraForward*bulletPower);

			}


			//次のたまごを表示
			if ( num % 2 == 1 ) {
				FirstImage.sprite = BlueEgg;
			} else if ( num % 2 == 0 ) {
				FirstImage.sprite = OrangeEgg;
			} 

			if ( num % 2 == 1 ) {
				SecondImage.sprite = OrangeEgg;
			} else if ( num % 2 == 0 ) {
				SecondImage.sprite = BlueEgg;
			} 


			//ファインプレイのテキストを表示
			this.FinePlayText.GetComponent<Text> ().text = "" ;
			if ( Eggnumber == 10) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "10";
			} else if (Eggnumber ==  20) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "20";
			} else if (Eggnumber ==  30) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "30";
			} else if (Eggnumber ==  35) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "35";
			} else if (Eggnumber ==  40) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "40";
			} else if (Eggnumber ==  45) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "45";
			} else if (Eggnumber ==  50) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "50";
			} else if (Eggnumber ==  55) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "55";
			} else if (Eggnumber == 60) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "60";
			} else if (Eggnumber == 65) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "65";
			} else if (Eggnumber ==  70) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "70";
			} else if (Eggnumber ==  75) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "75";
			} else if (Eggnumber ==  80) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "80";
			} else if (Eggnumber ==  85) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "85";
			} else if (Eggnumber ==  90) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "90";
			} else if (Eggnumber ==  95) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "95";
			} else if (Eggnumber == 97) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				this.FinePlayText.GetComponent<Text> ().text = "Fin";
				Invoke("GameClear", 1.0f);
			} 


			this.scoreText.GetComponent<Text> ().text = Eggnumber + " eggs";

			num += 1;
			Eggnumber += 1;

		}
	}


	void FinePlayTextClear() {
		this.FinePlayText.GetComponent<Text> ().text = "";
	}

	void GameClear() {
		SceneManager.LoadScene("EndScene");
	}

}
