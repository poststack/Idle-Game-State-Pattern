using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using DamageNumbersPro;



public class Warehouse : MonoBehaviour
{
	[SerializeField]
	private WareHouseView view;
	public UnityAction  ResourceChanged;
	
	public GameObject AddStockObject;
	public DamageNumber goodFloatingNumbers;
	public DamageNumber badFloatingNumbers;


	public int resourceCount = 4;
	//Array on type = Array of count
	public ResourceType[] types;
	public int[] counts;

	public ResourceType[] CanStore;
	
	void Start()
	{
		//resources = new Dictionary<ResourceType, int>();
		//resources.Add(ResourceType.Money, 5);
		//resources.Add(ResourceType.Wood, 5);
		//resources.Add(ResourceType.Stone, 5);
		//resources.Add(ResourceType.Iron, 5);
		

		
		types = new ResourceType[resourceCount];
		counts = new int[resourceCount];
		
		types[0] = ResourceType.Money;
		
		types[1] = ResourceType.Wood;
		
		types[2] = ResourceType.Stone;
		
		types[3] = ResourceType.Iron;
		
	}


	public bool CanSpendResource(ResourceType resourceType, int amount)
	{
		if (counts[(int)(resourceType)] >= amount)
		{
			return true;
		}
		else
		{
			return false;
		}
	}


	public void SpendResource(ResourceType resourceType, int amount)
	{
		counts[(int)(resourceType)] -= amount;
		DamageNumber damageNumber = badFloatingNumbers.Spawn
		(gameObject.transform.position,
			resourceType.ToString() + " "
			+ amount.ToString());

	}

	public void AddResource(ResourceType resourceType, int amount)
	{
		Debug.Log(gameObject.name + " "
			+ resourceType.ToString() + " "
			+ amount.ToString());
		counts[(int)(resourceType)] += amount;
		ResourceChanged?.Invoke();
		//GameObject Instantiate(AddStockObject,gameObject.transform);
		
		DamageNumber damageNumber = goodFloatingNumbers.Spawn
			(gameObject.transform.position,
			resourceType.ToString() + " "
			+ amount.ToString());

	}
	
	
	private void updateUI()
	{
		
		
	}
	
	


}
