using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Boss_1_HP : MonoBehaviour {
	public int BossHP;
	public int price;
	public static bool hit = false;
	public GameObject SpawnManager;
	public GameObject Explosion;

	// используйте этот метод для инициализации
	void Start () 
	{

	}

	// Update вызывается при отрисовке каждого кадра игры
	void Update () 
	{
			StartCoroutine(ExplosionFunc());
	}
	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Bullet")
		{
			BossHP -= Bullet.bulletDamage;
		}
	}
	IEnumerator ExplosionFunc() 
	{
		if (BossHP < 1) 
		{
			MoveInSpace.Boss = false;
			DestroyManager.DeadCount = true;
			CameraShake.Shake (0.5f, 1f);
			Explosion.SetActive (true);
			yield return new WaitForSeconds (1);
			ShopManager.money += price;
			Destroy (this.gameObject);
			yield return new WaitForSeconds (1);
			SpawnManager.SetActive (true);
		}
	}
}

