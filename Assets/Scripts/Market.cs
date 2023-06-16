using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Market : MonoBehaviour
{
	
	public Warehouse warehouse;
	[SerializeField] private List<Resource> _resources;
	//[SerializeField] private float _buyPriceMultiplier = 2f;
	//[SerializeField] private float _sellPriceMultiplier = 1f;

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		_resources = warehouse.resources;
	}

	public void TryBuyResource(ResourceType type, int amount)
	{
		var resource = _resources.Find(r => r.Type == type);

		if (warehouse.CanSubtractResource(ResourceType.Money,1))
		{
			//int totalPrice = Mathf.RoundToInt(resource.BuyPrice * amount * _buyPriceMultiplier);

			warehouse.SubtractResource(ResourceType.Money,1);
			warehouse.AddResource(type, amount);
		}


	}

	public void TrySellResource(ResourceType type, int amount)
	{
		var resource = _resources.Find(r => r.Type == type);

		if (warehouse.CanSubtractResource(type,1))
		{
			//int totalPrice = Mathf.RoundToInt(resource.BuyPrice * amount * _buyPriceMultiplier);

			warehouse.SubtractResource(type,1);
			warehouse.AddResource(ResourceType.Money, 1);
		}
	}
	
	
	public void WoodM(bool isBuying)
	{
		if (isBuying)
		{
			TryBuyResource(ResourceType.Wood,1);
		}
		else
		{
			TrySellResource(ResourceType.Wood,1);
		}
	}
	
	public void StoneM(bool isBuying)
	{
		if (isBuying)
		{
			TryBuyResource(ResourceType.Stone,1);
		}
		else
		{
			TrySellResource(ResourceType.Stone,1);
		}
	}
	
	public void IronM(bool isBuying)
	{
		if (isBuying)
		{
			TryBuyResource(ResourceType.Iron,1);
		}
		else
		{
			TrySellResource(ResourceType.Iron,1);
		}
	}
	
	public void HammerM(bool isBuying)
	{
		if (isBuying)
		{
			TryBuyResource(ResourceType.Hammer,1);
		}
		else
		{
			TrySellResource(ResourceType.Hammer,1);
		}
	}
	
	public void PitchforkM(bool isBuying)
	{
		if (isBuying)
		{
			TryBuyResource(ResourceType.Pitchfork,1);
		}
		else
		{
			TrySellResource(ResourceType.Pitchfork,1);
		}
	}
	
	public void DrillM(bool isBuying)
	{
		if (isBuying)
		{
			TryBuyResource(ResourceType.Drill,1);
		}
		else
		{
			TrySellResource(ResourceType.Drill,1);
		}
	}
	

}
