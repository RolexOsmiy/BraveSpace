using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed;
	private Transform thisTransform;

	// Use this for initialization
	void Start () {
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale != 0) 
		{
			thisTransform.Translate(-Vector3.up * speed);
		}
	}
}
