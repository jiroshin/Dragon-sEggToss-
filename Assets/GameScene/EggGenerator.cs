using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EggGenerator : MonoBehaviour {

	//RedBallPrefabを入れるためのゲームオブジェクトを作っておこう
	public GameObject WhiteEggPrefab; 
	public GameObject BlueEggPrefab;
	public GameObject GreyEggPrefab;
	public GameObject GreenEggPrefab;
	public GameObject OrangeEggPrefab;
	public GameObject RainbowEggPrefab;

	private int num;
	private int[] orderofballs = new int[100];
	public static int Eggnumber;

	private float bulletPower = 80f;

	//クリックした場所を入れるための変数も宣言するよ
	private Vector3 clickPosition;

	private GameObject scoreText;
	private GameObject FinePlayText;

	public Sprite WhiteEgg;
	public Sprite BlueEgg;
	public Sprite GrayEgg;
	public Sprite GreenEgg;
	public Sprite OrangeEgg;
	public Sprite RainbowEgg;
	public Image FirstImage;
	public Image SecondImage;
	public Image ThirdImage;
	public Image FourthImage;


	private AudioSource audioSource;
	public AudioClip audioClip1;
	public AudioClip audioClip2;


	// Use this for initialization
	void Start () {

		for(int i = 0; i<100 ; i++){
			num = Random.Range (1, 101);
			orderofballs [i] = num;
		}

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
			WhiteEggPrefab.transform.rotation = Random.rotation;

			//カメラ正面の向き
			Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

			if (orderofballs [Eggnumber] <= 19) {
				GameObject Egg = Instantiate(WhiteEggPrefab, Camera.main.ScreenToWorldPoint (clickPosition),  WhiteEggPrefab.transform.rotation);
				Egg.GetComponent<Rigidbody> ().AddForce (cameraForward*bulletPower);

			} else if (orderofballs [Eggnumber] <= 38) {
				GameObject Egg = Instantiate (BlueEggPrefab, Camera.main.ScreenToWorldPoint (clickPosition), WhiteEggPrefab.transform.rotation);
				Egg.GetComponent<Rigidbody> ().AddForce (cameraForward*bulletPower);

			} else if (orderofballs [Eggnumber] <= 57) {
				GameObject Egg = Instantiate (GreyEggPrefab, Camera.main.ScreenToWorldPoint (clickPosition), WhiteEggPrefab.transform.rotation);
				Egg.GetComponent<Rigidbody> ().AddForce (cameraForward*bulletPower);

			} else if (orderofballs [Eggnumber] <= 76) {
				GameObject Egg = Instantiate (GreenEggPrefab, Camera.main.ScreenToWorldPoint (clickPosition), WhiteEggPrefab.transform.rotation);
				Egg.GetComponent<Rigidbody> ().AddForce (cameraForward*bulletPower);

			} else if (orderofballs [Eggnumber] <= 95) {
				GameObject Egg = Instantiate (OrangeEggPrefab, Camera.main.ScreenToWorldPoint (clickPosition), WhiteEggPrefab.transform.rotation);
				Egg.GetComponent<Rigidbody> ().AddForce (cameraForward*bulletPower);

			} else if (orderofballs [Eggnumber] <= 100) {
				GameObject Egg = Instantiate (RainbowEggPrefab, Camera.main.ScreenToWorldPoint (clickPosition), WhiteEggPrefab.transform.rotation);
				Egg.GetComponent<Rigidbody> ().AddForce (cameraForward*bulletPower);
			} 


			//次のたまごを表示
			int nextcolor = Eggnumber + 1;
			if (orderofballs [nextcolor] <= 19) {
				FirstImage.sprite = WhiteEgg;
			} else if (orderofballs [nextcolor] <= 38) {
				FirstImage.sprite = BlueEgg;
			} else if (orderofballs [nextcolor] <= 57) {
				FirstImage.sprite = GrayEgg;
			} else if (orderofballs [nextcolor] <= 76) {
				FirstImage.sprite = GreenEgg;
			} else if (orderofballs [nextcolor] <= 95) {
				FirstImage.sprite = OrangeEgg;
			} else if (orderofballs [nextcolor] <= 100) {
				FirstImage.sprite = RainbowEgg;
			} 
			int next2color = Eggnumber + 2;
			if (orderofballs [next2color] <= 19) {
				SecondImage.sprite = WhiteEgg;
			} else if (orderofballs [next2color] <= 38) {
				SecondImage.sprite = BlueEgg;
			} else if (orderofballs [next2color] <= 57) {
				SecondImage.sprite = GrayEgg;
			} else if (orderofballs [next2color] <= 76) {
				SecondImage.sprite = GreenEgg;
			} else if (orderofballs [next2color] <= 95) {
				SecondImage.sprite = OrangeEgg;
			} else if (orderofballs [nextcolor] <= 100) {
				SecondImage.sprite = RainbowEgg;
			} 
			int next3color = Eggnumber + 3;
			if (orderofballs [next3color] <= 19) {
				ThirdImage.sprite = WhiteEgg;
			} else if (orderofballs [next3color] <= 38) {
				ThirdImage.sprite = BlueEgg;
			} else if (orderofballs [next3color] <= 57) {
				ThirdImage.sprite = GrayEgg;
			} else if (orderofballs [next3color] <= 76) {
				ThirdImage.sprite = GreenEgg;
			} else if (orderofballs [next3color] <= 95) {
				ThirdImage.sprite = OrangeEgg;
			} else if (orderofballs [nextcolor] <= 100) {
				ThirdImage.sprite = RainbowEgg;
			} 
			int next4color = Eggnumber + 3;
			if (orderofballs [next4color] <= 19) {
				FourthImage.sprite = WhiteEgg;
			} else if (orderofballs [next4color] <= 38) {
				FourthImage.sprite = BlueEgg;
			} else if (orderofballs [next4color] <= 57) {
				FourthImage.sprite = GrayEgg;
			} else if (orderofballs [next4color] <= 76) {
				FourthImage.sprite = GreenEgg;
			} else if (orderofballs [next4color] <= 95) {
				FourthImage.sprite = OrangeEgg;
			} else if (orderofballs [next4color] <= 100) {
				FourthImage.sprite = RainbowEgg;
			} 


			//ファインプレイのテキストを表示
			this.FinePlayText.GetComponent<Text> ().text = "" ;
			if (nextcolor == 10) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "10";
			} else if (nextcolor == 20) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "20";
			} else if (nextcolor == 30) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "30";
			} else if (nextcolor == 35) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "35";
			} else if (nextcolor == 40) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "40";
			} else if (nextcolor == 45) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "45";
			} else if (nextcolor == 50) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "50";
			} else if (nextcolor == 55) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "55";
			} else if (nextcolor == 60) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "60";
			} else if (nextcolor == 65) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "65";
			} else if (nextcolor == 70) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "70";
			} else if (nextcolor == 75) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "75";
			} else if (nextcolor == 80) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
			 	this.FinePlayText.GetComponent<Text> ().text = "80";
			} else if (nextcolor == 85) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "85";
			} else if (nextcolor == 90) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "90";
			} else if (nextcolor == 95) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				Invoke("FinePlayTextClear", 0.7f);
				this.FinePlayText.GetComponent<Text> ().text = "95";
			} else if (nextcolor == 97) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
				this.FinePlayText.GetComponent<Text> ().text = "Fin";
				Invoke("GameClear", 1.0f);
			} 


			this.scoreText.GetComponent<Text> ().text = nextcolor + " eggs";

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