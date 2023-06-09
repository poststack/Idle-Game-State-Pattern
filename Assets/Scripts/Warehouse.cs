using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using Sirenix.OdinInspector;


public class Warehouse : MonoBehaviour
{
	
	public UnityAction  ResourceChanged;

	[DictionaryDrawerSettings(KeyLabel = "Custom Key Name", ValueLabel = "Custom Value Label")]
	public Dictionary<ResourceType, int> resources;

	public ResourceType[] CanStore;
	
	[OnInspectorInit]
	void Start()
	{
		resources = new Dictionary<ResourceType, int>();
		resources.Add(ResourceType.Money, 0);
		resources.Add(ResourceType.Wood, 0);
		resources.Add(ResourceType.Stone, 0);
		resources.Add(ResourceType.Iron, 0);
	}


	public bool CanSpendResource(ResourceType resourceType, int amount)
	{
		if (resources[resourceType] >= amount)
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
		resources[resourceType] -= amount;

	}

	public void AddResource(ResourceType resourceType, int amount)
	{
		Debug.Log(gameObject.name + " "
			+ resourceType.ToString() + " "
			+ amount.ToString());
		resources[resourceType] += amount;
		ResourceChanged?.Invoke();
	}
	
	
	


}
