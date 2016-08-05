using UnityEngine;
using System.Collections;

public class SaveLoad : MonoBehaviour {
	public int highScore;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.K)) 
		{
			PlayerPrefs.SetFloat ("SScore", ScoreManager.score);
			PlayerPrefs.Save ();
		}
		if (Input.GetKey (KeyCode.L)) 
		{
			PlayerPrefs.SetInt ("SScore", highScore);
			PlayerPrefs.Save ();
		}
	}
}