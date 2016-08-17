using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
	public GameObject AskMenu;
	public GameObject OptionsMenu;
	public GameObject Play;
	public GameObject Options;
	public GameObject Exit;
	public GameObject ToMainMenu;
	public GameObject Lose;
	public GameObject Managers;
	public static bool EscapeOn;
	public GameObject Shoot;

	void Update ()
	{
		if (ShopManager.ShopManagerOn == false) {
			if (Input.GetKeyDown (KeyCode.Escape)) {
				ToMainMenu.SetActive (true);
				Time.timeScale = 0;  
				ShopManager.pause = true;
				EscapeOn = true;
				Shoot.SetActive (false);
			}
		}
	}

	public void onClickPlay()
	{
		//ScoreManager.score = 0;
		ShopManager.Reset = true;
		SceneManager.LoadScene ("level");
	}
	public void onClickExit()
	{
		AskMenu.SetActive (true);
		Play.SetActive (false);
		Options.SetActive (false);
		Exit.SetActive (false);
	}
	public void onClickYes()
	{
		Application.Quit();
	}
	public void onClickNo()
	{
		AskMenu.SetActive (false);
		Play.SetActive (true);
		Options.SetActive (true);
		Exit.SetActive (true);
	}
	public void onClickOptions()
	{
		OptionsMenu.SetActive (true);
		Play.SetActive (false);
		Options.SetActive (false);
		Exit.SetActive (false);
	}
	public void onClickBack()
	{
		OptionsMenu.SetActive (false);
		Play.SetActive (true);
		Options.SetActive (true);
		Exit.SetActive (true);
	}
	public void onClickYesLevel()
	{
		SceneManager.LoadScene ("MainMenu");
	}
	public void onClickNoLevel()
	{
		ToMainMenu.SetActive (false);
		Time.timeScale = 1;  
		ShopManager.pause = false; 
		EscapeOn = false;
		Shoot.SetActive (true);
	}
	public void onClickRestartLevel()
	{
		RestartFunction ();
	}
	void RestartFunction ()
	{
		ScoreManager.score = 0;
		ShopManager.Reset = true;
		Lose.SetActive (false);
		SceneManager.LoadScene ("level");
		Managers.SetActive (true);
		Shoot.SetActive (true);
	}

}