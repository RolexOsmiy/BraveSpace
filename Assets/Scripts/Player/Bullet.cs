using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bullet : MonoBehaviour {
    public float speed;
	public static int bulletDamage = 1;
    Vector2 _direction;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{ 
		bulletDamage = (ShopManager.DamageCount);
        Vector2 position = transform.position;
        position += _direction * speed * Time.deltaTime;
        transform.position = position;
        transform.position = position;
    }

    public void SetDirection(Vector2 targetDirection)
    {
        _direction = targetDirection.normalized;
    }

    public void RotateToTarget(Vector2 targetDirection)
    {
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        transform.localRotation = Quaternion.AngleAxis(angle - 90, new Vector3(0, 0, 1));
    }

    public void Rotate(Quaternion rotation)
    {
        transform.rotation = rotation;
    }

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Enemy") 
		{
			this.gameObject.SetActive (false);
		}
	} 
}
