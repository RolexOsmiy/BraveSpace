using UnityEngine;
using System.Collections;

public class PlayerGun : MonoBehaviour {
	public int damageSound = 0;
	public AudioClip damageClip;
    public int fireRateInMin;
	public float firaTime;

	// Use this for initialization
	void Start () {

        firaTime = 60f / fireRateInMin;

    }
	
	// Update is called once per frame
	void Update () {
		if (damageSound == 1) 
		{
			GetComponent<AudioSource>().PlayOneShot(damageClip);
			damageSound = 0;
		}

        if (Input.GetMouseButtonDown(0)) {
            InvokeRepeating("Fire", 0, firaTime);
        }

        if (Input.GetMouseButtonUp(0))
        {
            CancelInvoke("Fire");
        }

    }

    void Fire()
    {

        GameObject bullet = GameObject.Find("NormalBulletsPool").GetComponent<ObjectPoller>().GetPooledObject();

        if (bullet == null) return;

        bullet.transform.position = transform.position;
        //bullet.transform.rotation = transform.rotation;
        Vector2 direction = bullet.transform.position -transform.parent.position;
        bullet.GetComponent<Bullet>().SetDirection(direction);
        // bullet.GetComponent<Bullet>().RotateToTarget(direction);
        bullet.GetComponent<Bullet>().Rotate(transform.parent.rotation);
        bullet.SetActive(true);
		damageSound = 1;

    }
}
