using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	public static float score = 0;
	public Text scoreText;
	public GameObject SpawnManager;
	public GameObject Boss_1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		score = score + 1 * Time.deltaTime;
		scoreText.text = "Score: " + (int) score;
		if ((((int)score + 1) % 250) == 0)
		{
			Boss_1.SetActive (true);
			MoveInSpace.Boss = true;
			SpawnManager.SetActive (false);
		} 
	}
}
