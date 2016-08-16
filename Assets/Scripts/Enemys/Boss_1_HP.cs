using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Boss_1_HP : MonoBehaviour {
	public int BossHP;
	public int price;
	public static bool hit = false;
	public GameObject SpawnManager;

	// используйте этот метод для инициализации
	void Start () 
	{

	}

	// Update вызывается при отрисовке каждого кадра игры
	void Update () 
	{
		if (BossHP < 1)
		{
			MoveInSpace.Boss = false;
			DestroyManager.DeadCount = true;
			ShopManager.money += price;
			SpawnManager.SetActive (true);
			Destroy(this.gameObject);
		}
	}
	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Bullet")
		{
			BossHP -= Bullet.bulletDamage;
		}
	}
}

