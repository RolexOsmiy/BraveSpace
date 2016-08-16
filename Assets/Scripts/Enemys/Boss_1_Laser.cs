using UnityEngine;
using System.Collections;

public class Boss_1_Laser : MonoBehaviour {
	public float LaserDamage;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	void OnTriggerStay2D (Collider2D collider)
	{
		if(collider.tag == "Player")
		{	
			DestroyManager.shootCount = 1;
			DestroyManager.health -= LaserDamage;
			CameraShake.Shake(0.2f, 0.2f);
		}
	}
}

