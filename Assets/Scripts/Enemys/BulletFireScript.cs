using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletFireScript : MonoBehaviour {
	public float fireTime = 0.5f;

	// Use this for initialization
	void Start ()
	{
		InvokeRepeating ("Fire", fireTime, fireTime);
	}
	
	// Update is called once per frame
	void Fire ()
	{
		GameObject obj = EnemyBulletPooler.current.GetPooledObject ();
		if (obj == null) return;
		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;
		obj.SetActive (true);
	}
}

