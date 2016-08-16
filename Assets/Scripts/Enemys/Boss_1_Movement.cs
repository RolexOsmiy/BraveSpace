using UnityEngine;
using System.Collections;

public class Boss_1_Movement : MonoBehaviour {
	public bool Comming;
	public bool LaserRotate;
	public bool LeftRightMove;
	public float speed;
	public float rotateSpeed;
	public Vector3 CommingPos;
	public GameObject GunLeft;
	public GameObject GunRight;
	public GameObject LaserLeft;
	public GameObject LaserRight;
	public GameObject ShootSystem;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Vector3.Distance (transform.position,CommingPos) <= 1)
		{
			Comming = true;
			LaserLeft.SetActive (true);
			LaserRight.SetActive (true);
			ShootSystem.SetActive (true);
		}

		if (Comming == false) {
			transform.Translate (-Vector3.up * speed);
		} 
			if (LaserRotate == false) 
			{
				Inside ();
			} 
			else 
			{ 
				Out ();
			}

			if (GunLeft.transform.eulerAngles.z > 120) 
			{
				LaserRotate = true;
			}

			if (GunLeft.transform.eulerAngles.z < 1) 
			{
				LaserRotate = false;
			}
		}
	void Inside ()
	{
		GunLeft.transform.Rotate (0, 0, rotateSpeed * Time.deltaTime, Space.Self);
		GunRight.transform.Rotate (0, 0, -rotateSpeed * Time.deltaTime, Space.Self);
	}
	void Out ()
	{
		GunLeft.transform.Rotate (0, 0, -rotateSpeed * Time.deltaTime, Space.Self);
		GunRight.transform.Rotate (0, 0, rotateSpeed * Time.deltaTime, Space.Self);
	}
}


