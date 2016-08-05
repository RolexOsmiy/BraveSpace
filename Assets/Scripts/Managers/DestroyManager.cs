using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyManager : MonoBehaviour {
	public static float health = 100f;
	public float startHP;
	public Image img;
	public static float damage;
	public static int shootCount = 0;
	public AudioClip damageClip;
	public Text HPTextBar;
	public static int maxHP = 100;
	public float hpReg = 1;
	public static bool DeadCount = false;
	public AudioClip Dead;

	// Use this for initialization
	void Start () {

	}

	void Awake () {
		startHP = health;
	}
	
	// Update is called once per frame
	void Update () 
	{
		damage = (ScoreManager.score * 50/100);
		if (DeadCount == true) 
		{
			GetComponent<AudioSource>().PlayOneShot(Dead);
			DeadCount = false;
		}
		if (health < maxHP) 
		{
			health += ShopManager.HPRegCount * Time.deltaTime;
		}
		HPTextBar.text = ""+Mathf.Round(health * 1f) / 1f;
		health += hpReg * Time.deltaTime;
		if (health > maxHP) 
		{
			health = maxHP;
		}
		if (shootCount == 1) 
		{
			GetComponent<AudioSource>().PlayOneShot(damageClip, 0.7F);
			shootCount = 0;
		}
		float scaleX = health/maxHP;
		img.transform.localScale = new Vector3 (scaleX, 1, 1);
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if(collider.tag == "Enemy")
		{
			Destroy(collider.gameObject);
			health = health - damage;
			shootCount = 1;
		}
		if(collider.tag == "EnemyBullet")
		{
			collider.gameObject.SetActive(false);
		}
	}
}
