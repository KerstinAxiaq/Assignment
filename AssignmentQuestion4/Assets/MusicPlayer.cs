using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer myMusicPlayer = null;

	// Use this for initialization
	void Start () {
		
	}

	void Awake()
	{
		//if myMusicPlayer already exists
		if (myMusicPlayer != null)
		{
			//Destroy the new object immediately
			Destroy(this.gameObject);
			print("Duplicate music player self-destructing");
		}
		else //if myMusicPlayer is null
		{
			//myMusicPlayer is this object and it is no longer null
			myMusicPlayer = this;

			//gameObject = musicPlayerObject with all its components
			//the gameObject that this script is attached to
			//music keeps on playing while browsing the scenes

			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
