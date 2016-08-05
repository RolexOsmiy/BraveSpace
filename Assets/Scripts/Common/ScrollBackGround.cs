using UnityEngine;
using System.Collections;

public class ScrollBackGround : MonoBehaviour {
	public Transform[] backgrounds;
	public float speed;
	//public Renderer rend;

	void Start () 
	{
		//rend = GetComponent<Renderer>();
	}

	void Update () 
	{
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (Time.time * speed, 0f);
	}
}
