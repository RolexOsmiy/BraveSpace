using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Explosion : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		
	}
	void Update ()
	{
		StartCoroutine(Example());
	}
	IEnumerator Example() {
		yield return new WaitForSeconds(0.1f);
		Destroy(gameObject);
	}
}

