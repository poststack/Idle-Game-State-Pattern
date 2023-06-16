using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryScript : MonoBehaviour
{
	public GameObject VictoryCanvas;
	public Sprite[] VictorySprites;
	public Image Victoryimage;
	
	
	public Warehouse warehouse;
	public Resource[] requiredResources;
	
	//МНЕ СТЫДНО, НО Я НЕ ЗНАЮ, КАК ПОКАЗАТЬ ТИП 
	//Resource В ИНСПЕКТОРЕ 
	public ResourceType[] requiredResourceType;
	public int[] requiredResourceCount;

	[SerializeField]
	private bool victoryAchieved = false;


	protected void Start()
	{
		VictoryCanvas.SetActive(false); 
		requiredResources = new Resource[requiredResourceType.Length];
		for (int i = 0; i < requiredResourceType.Length; i++)
		{
			requiredResources[i] = new Resource(requiredResourceType[i], requiredResourceCount[i]);
		}
	}


	private void OnEnable()
	{
		warehouse.OnResourceChanged += CheckVictory;
	}

	private void OnDisable()
	{
		warehouse.OnResourceChanged -= CheckVictory;
	}

	private void CheckVictory()
	{
		
		if (!victoryAchieved)
		{
			bool allResourcesFound = warehouse.CanSubtractMultipleResource(requiredResources);
			

			if (allResourcesFound)
			{
				victoryAchieved = true;
				VictoryMethod();
			}
		}
	}
	
	private void VictoryMethod()
	{
		Debug.Log("Victory achieved!");
		int randomIndex = Random.Range(0, VictorySprites.Length);
		Sprite randomSprite = VictorySprites[randomIndex];

		// Set the Image component's sprite to the random sprite
		Victoryimage.sprite = randomSprite;
		VictoryCanvas.SetActive(true);
		StartCoroutine(TimerCoroutine());

	}
	IEnumerator TimerCoroutine()
	{
		yield return new WaitForSeconds(3);
		VictoryCanvas.SetActive(false);

   	
	}

	
}
