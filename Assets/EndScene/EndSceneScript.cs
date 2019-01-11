using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneScript : MonoBehaviour {

	private int score;
	private GameObject ResultText;
	private GameObject CommentText;

	// Use this for initialization
	void Start () {
		this.score = EggGenerator.Eggnumber;
		this.ResultText = GameObject.Find("ResultText");
		this.ResultText.GetComponent<Text> ().text = score + "\r\neggs";

		this.CommentText = GameObject.Find("Comment");
	}

	// Update is called once per frame
	void Update () {
		if (score < 20) {
			this.CommentText.GetComponent<Text> ().text = "Just getting started! Let's play again!";
		} else if (score < 30) {
			this.CommentText.GetComponent<Text> ().text = "Let's not give up! You can do it!";
		} else if (score < 40) {
			this.CommentText.GetComponent<Text> ().text = "GOOD! GO! GO!Let's go!";
		} else if (score < 45) {
			this.CommentText.GetComponent<Text> ().text = "GOOD! You're really improving.";
		} else if (score < 50) {
			this.CommentText.GetComponent<Text> ().text = "Nice Play! Let's play one more!";
		} else if (score < 55) {
			this.CommentText.GetComponent<Text> ().text = "Amazing! You're Nice Player!! Try a bit more!";
		} else if (score < 60) {
			this.CommentText.GetComponent<Text> ().text = "Superb! GOOOOOD! Good work! You're SuperPlayer!!";
		} else if (score < 65) {
			this.CommentText.GetComponent<Text> ().text = "Incredible! Keep up the good work!";
		} else if (score < 70) {
			this.CommentText.GetComponent<Text> ().text = "Nothing can stop you now! Great!";
		} else if (score < 75) {
			this.CommentText.GetComponent<Text> ().text = "I've never seen anyone do it better.Thank you for your playing.";
		} else if (score < 97) {
			this.CommentText.GetComponent<Text> ().text = "You're SuperPlayer! Thank you for your playing. I'm very proud of you. See you:)";
		} else if (score >= 97) {
			this.CommentText.GetComponent<Text> ().text = "Congratulations! You complete this Game! I'm very proud of you. Thank you:)";
		} 

	}
}