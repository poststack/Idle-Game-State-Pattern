using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;


public class WareHouseView : MonoBehaviour
{
	public TextMeshProUGUI text;
	
	private Vector2 initialSize;
	public Vector2 targetSize;
	
	
	//Money
	[SerializeField]
	private GameObject moneyInventoryPanel;
	[SerializeField]
	private Image moneyImage;
	
	[SerializeField]
	private Sprite moneySprite;
	
	[SerializeField]
	private TextMeshProUGUI moneyText;
	
	[Space (20)]
	//wood
	[SerializeField]
	private GameObject woodInventoryPanel;
	[SerializeField]
	private Image woodImage;
	
	[SerializeField]
	private Sprite woodSprite;
	
	[SerializeField]
	private TextMeshProUGUI woodText;
	
	[Space (20)]
	[SerializeField]
	private GameObject stoneInventoryPanel;
	//stone
	[SerializeField]
	private Image stoneImage;
	
	[SerializeField]
	private Sprite stoneSprite;
	
	[SerializeField]
	private TextMeshProUGUI stoneText;
	
	
	[Space (20)]
	[SerializeField]
	private GameObject ironInventoryPanel;
	//iron
	[SerializeField]
	private Image ironImage;
	
	
	[SerializeField]
	private Sprite ironSprite;
	
	[SerializeField]
	private TextMeshProUGUI ironText;

	//Hammer
	[Space (20)]
	[SerializeField]
	private GameObject HammerInventoryPanel;
	[SerializeField]
	private TextMeshProUGUI HammerText;
	//Pitchfork
	[Space (20)]
	[SerializeField]
	private GameObject PitchforkInventoryPanel;
	[SerializeField]
	private TextMeshProUGUI PitchforkText;
	
	//Drill
	[Space (20)]
	[SerializeField]
	private GameObject DrillInventoryPanel;
	[SerializeField]
	private TextMeshProUGUI DrillText;

	TextMeshProUGUI GameObjectToText(GameObject parentObject)
	{
		return parentObject.transform.GetChild(1).
			GetComponent<TextMeshProUGUI>();
	}
	
	

	protected void Start()
	{
		DOTween.Init();
		
		moneyText = GameObjectToText(moneyInventoryPanel);
		//moneyImage.sprite = moneySprite;
		moneyText.text = 0.ToString("00");
		woodText = GameObjectToText(woodInventoryPanel);
		//woodImage.sprite = woodSprite;
		woodText.text = "0";
		stoneText = GameObjectToText(stoneInventoryPanel);
		//stoneImage.sprite = stoneSprite;
		stoneText.text = "0";
		ironText = GameObjectToText(ironInventoryPanel);
		//ironImage.sprite = ironSprite;
		ironText.text = "0";
		
	}

	public void updateInventoryUI(ResourceType resourceType, int amount)
	{
		if (resourceType == ResourceType.Money)
			updateMoney(amount);
		else if(resourceType == ResourceType.Wood)
			updatewood(amount);
		else if(resourceType == ResourceType.Stone)
			updatestone(amount);
		else if(resourceType == ResourceType.Iron)
			updateiron(amount);
		else if(resourceType == ResourceType.Money)
			updateMoney(amount);
	}
	

	
	private void Grow(RectTransform rectTransform)
	{
		initialSize = rectTransform.sizeDelta;
		targetSize = initialSize*1.2f;
		rectTransform.
			DOSizeDelta(targetSize, 0.1f);//.OnComplete(Shrink(rectTransform));
	}
	
	private void Shrink(RectTransform rectTransform)
	{
		//rectTransform.DOSizeDelta(initialSize, 0.1f).OnComplete(Grow);
	}
	
	public void updateMoney(int money)
	{
		//moneyImage.sprite = moneySprite;
		//moneyImage.DOColor(Color.green,0.1f);
		moneyText.text = money.ToString();
		Grow(moneyInventoryPanel.GetComponent<RectTransform>());
		
	}
	
	public void updatewood(int wood)
	{
		//woodImage.sprite = woodSprite;
		woodText.text = wood.ToString();
		
	}
	
	public void updatestone(int stone)
	{
		//stoneImage.sprite = stoneSprite;
		stoneText.text = stone.ToString();
		
	}
	
	public void updateiron(int iron)
	{
		//ironImage.sprite = ironSprite;
		ironText.text = iron.ToString();
		
	}
	
	public void updateHammer(int Hammer)
	{
		//HammerImage.sprite = HammerSprite;
		HammerText.text = Hammer.ToString();
		
	}
	
	public void updatePitchFork(int PitchFork)
	{
		//PitchForkImage.sprite = PitchForkSprite;
		PitchforkText.text = PitchFork.ToString();
		
	}
	
	
	public void updateDrill(int Drill)
	{
		//DrillImage.sprite = DrillSprite;
		DrillText.text = Drill.ToString();
		
	}

	public GameObject InventoryPanel;
	public GameObject ObjectPrefab;

	public void CreateInventory()
	{
		
		
	}
}
