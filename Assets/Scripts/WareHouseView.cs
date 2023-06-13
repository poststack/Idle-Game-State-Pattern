using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WareHouseView : MonoBehaviour
{
	public TextMeshProUGUI text;
	
	
	//Money
	[SerializeField]
	private Image moneyImage;
	
	[SerializeField]
	private Sprite moneySprite;
	
	[SerializeField]
	private TextMeshProUGUI moneyText;
	
	[Space (20)]
	//wood
	[SerializeField]
	private Image woodImage;
	
	[SerializeField]
	private Sprite woodSprite;
	
	[SerializeField]
	private TextMeshProUGUI woodText;
	
	[Space (20)]
	//stone
	[SerializeField]
	private Image stoneImage;
	
	[SerializeField]
	private Sprite stoneSprite;
	
	[SerializeField]
	private TextMeshProUGUI stoneText;
	
	
	[Space (20)]
	//iron
	[SerializeField]
	private Image ironImage;
	
	[SerializeField]
	private Sprite ironSprite;
	
	[SerializeField]
	private TextMeshProUGUI ironText;

	protected void Start()
	{
		moneyImage.sprite = moneySprite;
		moneyText.text = "0";
		woodImage.sprite = woodSprite;
		woodText.text = "0";
		stoneImage.sprite = stoneSprite;
		stoneText.text = "0";
		ironImage.sprite = ironSprite;
		ironText.text = "0";
		
	}

	public void updateUI(int money, int wood, int stone, int iron)
	{
		
	}
	
	
	public void updateMoney(int money)
	{
		moneyImage.sprite = moneySprite;
		moneyText.text = money.ToString();
		
	}
	
	public void updatewood(int wood)
	{
		woodImage.sprite = woodSprite;
		woodText.text = wood.ToString();
		
	}
	
	public void updatestone(int stone)
	{
		stoneImage.sprite = stoneSprite;
		stoneText.text = stone.ToString();
		
	}
	
	public void updateiron(int iron)
	{
		ironImage.sprite = ironSprite;
		ironText.text = iron.ToString();
		
	}

}
