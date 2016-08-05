using UnityEngine;
using System.Collections;

public class VolumeControl : MonoBehaviour {
	public AudioSource MainTheme;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		MainTheme.volume = Settings.VolCount;
	}
}

