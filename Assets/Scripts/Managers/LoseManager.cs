using UnityEngine;
using System.Collections;

public class LoseManager : MonoBehaviour {
	public GameObject Lose;
	public GameObject Managers;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (DestroyManager.health <= 0) 
		{
			ShopManager.pause = true;
			Managers.SetActive (false);
			Lose.SetActive (true);
		}
	}
}

