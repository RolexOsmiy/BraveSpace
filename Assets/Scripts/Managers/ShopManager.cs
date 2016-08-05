using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShopManager : MonoBehaviour {
	public static bool pause;
	public static bool Reset;
	public GameObject Shop;
	public Text DamageText;
	public Text HPRegText;
	public Text HPText;
	public Text DamagePriceText;
	public Text HPRegPriceText;
	public Text HPPriceText;
	public Text MoneyScore;
	public Text CashBar;
	public Text DMGBar;
	public static int DamageCount = 1;
	public static float HPRegCount = 1;
	public static int HPCount = 1;
	public static int money;
	public int priceUPDamage = 10;
	public int priceUPReg = 30;
	public int priceUPHP = 10;
	public GameObject Shoot;
	public GameObject ToMainMenu;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Reset == true) 
		{
			ResetFunction ();
			Reset = false;
		}
		if (Input.GetKeyDown (KeyCode.B)) 
		{
			if (!pause) 
			{
				Time.timeScale = 0;
				pause = true; 
				Shop.SetActive(true);
				Shoot.SetActive (false);
			}
		}
		DMGBar.text = (int)DamageCount+" DMG";
		CashBar.text = (int)money + " $";
		MoneyScore.text = (int)money + " $";
		DamagePriceText.text = ""+priceUPDamage;
		HPRegPriceText.text = ""+priceUPReg;
		HPPriceText.text = ""+priceUPHP;
	}
	public void onClickBackShop()
	{
		Time.timeScale = 1;  
		pause = false; 
		Shop.SetActive(false);
		Shoot.SetActive (true);
	}
	public void onClickUpDamage()
	{
		if (money >= priceUPDamage) 
		{
			money -= priceUPDamage;
			DamageCount += 1;
			DamageText.text = ""+DamageCount;
			priceUPDamage = priceUPDamage + priceUPDamage * 25 / 100;
		}
	}
	public void onClickUpHPReg()
	{
		if (money >= priceUPReg) 
		{
			money -= priceUPReg;
			HPRegCount += 1;
			HPRegText.text = ""+HPRegCount;
			priceUPReg = priceUPReg + priceUPReg * 25 / 100;
		}
	}
	public void onClickUPHP()
	{
		if (money >= priceUPHP) 
		{
			money -= priceUPHP;
			HPCount += 1;
			HPText.text = ""+HPCount;
			DestroyManager.maxHP += (HPCount * 10); 
			priceUPHP = priceUPHP + priceUPHP * 25 / 100;
		}
	}
	void ResetFunction ()
	{
		DamageCount = 1;
		HPRegCount = 1;
		HPCount = 1;
		money = 0;
		priceUPDamage = 10;
		priceUPReg = 30;
		priceUPHP = 10;
		DestroyManager.health = 100;
		DestroyManager.maxHP = 100;
		pause = false;
	}
}

