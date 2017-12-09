using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour {

	public Text textPlayer1;
	public Text textPlayer2;
	public int scorePlayer1;
	public int scorePlayer2;
	public int score;
	public int max;
	public string scene;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		if(scorePlayer1==max || scorePlayer2==max){
			SceneManager.LoadScene(scene);
		}
	}

	void OnCollisionEnter2D(Collision2D theCollision){
		if(theCollision.gameObject.name == "Player2Score"){
			Debug.Log ("right");
			scorePlayer2 += score;
			TotalScore.TotalPlayer2 += score;
			textPlayer2.text = scorePlayer2+"";
		}else if(theCollision.gameObject.name == "Player1Score"){
			Debug.Log ("left");
			scorePlayer1 += score;
			TotalScore.TotalPlayer1 += score;
			textPlayer1.text = scorePlayer1+"";
		}
	}

		

}
