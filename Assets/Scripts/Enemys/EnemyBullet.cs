using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	public static int BulletDamage;
	public int TrueDamage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		BulletDamage = TrueDamage;
		TrueDamage =(int)(ScoreManager.score * 35/100);
		if (TrueDamage < 1) 
		{
			TrueDamage = 1;
		}
	}
	void OnTriggerEnter2D (Collider2D collider)
	{
		if(collider.tag == "Player")
		{	
			DestroyManager.shootCount = 1;
			DestroyManager.health -= BulletDamage;
			CameraShake.Shake(0.2f, 0.2f);
		}
	}
}