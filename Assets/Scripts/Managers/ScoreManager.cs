using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	public static float score = 0;
	public Text scoreText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		score = score + 1 * Time.deltaTime;
		scoreText.text = "Score: " + (int) score;
	}
}
