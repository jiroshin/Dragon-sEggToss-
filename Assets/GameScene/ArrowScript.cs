using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowScript : MonoBehaviour {

	//public Sprite ArrowImage;
	//public Image Arrow;

	private GameObject Arrow;
	// Alpha増減値(点滅スピード調整)
	private float _Step = 0.02f;

	// Use this for initialization
	void Start () {
		this.Arrow = GameObject.Find("Arrow");
	}
	
	// Update is called once per frame
	void Update () {
		// 現在のAlpha値を取得
		float toColor = this.Arrow.GetComponent<Image>().color.a;
		// Alphaが0 または 1になったら増減値を反転
		if (toColor < 0 || toColor > 1){
			_Step = _Step * -1;
		}
		// Alpha値を増減させてセット
		this.Arrow.GetComponent<Image>().color = new Color(255, 255, 255, toColor + _Step);
	}
}
