using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalScore : MonoBehaviour {

	private static int totalPlayer1,totalPlayer2;

	public static int TotalPlayer1 {
		get {
			return totalPlayer1;
		}
		set {
			totalPlayer1 = value;
		}
	}

	public static int TotalPlayer2 {
		get {
			return totalPlayer2;
		}
		set {
			totalPlayer2 = value;
		}
	}

}
