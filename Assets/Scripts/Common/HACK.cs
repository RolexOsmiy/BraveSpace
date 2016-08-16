using UnityEngine;
using System.Collections;

public class HACK : MonoBehaviour {
	public GameObject Boss_1;
	public GameObject SpawnManager;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp(KeyCode.H))
		{
			SpawnManager.SetActive (false);
			Boss_1.SetActive (true);
			ShopManager.money = 5000;

		}
	}
}

