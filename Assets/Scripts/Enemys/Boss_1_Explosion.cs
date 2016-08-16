using UnityEngine;
using System.Collections;

public class Boss_1_Explosion : MonoBehaviour {
	public GameObject Explosion_1;
	public GameObject Explosion_2;
	public GameObject Explosion_3;
	public GameObject Explosion_4;
	public GameObject Explosion_5;
	public GameObject Explosion_6;
	public GameObject Explosion_7;
	public GameObject Explosion_8;
	public GameObject Explosion_9;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		CameraShake.Shake(5, 0.2f);
	}
	IEnumerator Explosion() {
		Explosion_1.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		Explosion_2.SetActive (true);
		Explosion_3.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		Explosion_4.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		Explosion_5.SetActive (true);
		yield return new WaitForSeconds(0.7f);
		Explosion_6.SetActive (true);
		yield return new WaitForSeconds(0.2f);
		Explosion_7.SetActive (true);
		yield return new WaitForSeconds(0.3f);
		Explosion_8.SetActive (true);
		yield return new WaitForSeconds(0.1f);
		Explosion_9.SetActive (true);
	}
}

