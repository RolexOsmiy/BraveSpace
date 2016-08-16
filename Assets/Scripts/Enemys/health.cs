using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class health : MonoBehaviour {
	public int EnemyHP;
	public int price;
	public static bool hit = false;
	public GameObject Explosion;

	// используйте этот метод для инициализации
	void Start () 
	{
		
	}

	// Update вызывается при отрисовке каждого кадра игры
	void Update () 
	{
		if (EnemyHP < 1){
			DestroyManager.DeadCount = true;
			Destroy(this.gameObject);
			ShopManager.money += price; 
			Instantiate(Explosion, transform.position, transform.rotation);
		}
	}
	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Bullet")
		{
			EnemyHP -= Bullet.bulletDamage;
		}
	}
}

