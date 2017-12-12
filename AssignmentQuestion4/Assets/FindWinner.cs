using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindWinner : MonoBehaviour {

	public Text textWinner;
	public Text textScore;

	// Use this for initialization
	void Start () {
		if(TotalScore.TotalPlayer2>TotalScore.TotalPlayer1){
			Debug.Log ("p2");
			textWinner.text = "Winner Player 2";
			textScore.text = "Score: "+TotalScore.TotalPlayer2;
		}else if(TotalScore.TotalPlayer2<TotalScore.TotalPlayer1){
			Debug.Log ("p1");
			textWinner.text = "Winner Player 1";
			textScore.text = "Score: "+TotalScore.TotalPlayer1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
