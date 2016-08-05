using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;

public class Settings : MonoBehaviour {
	public Slider MySlider;
	public static float VolCount;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		VolCount = MySlider.value;
	}
	public void AudioOptions()
	{
		AudioListener.volume = VolCount;
	}
}

