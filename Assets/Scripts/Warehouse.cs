using System.Collections.Generic;
using UnityEngine.Events;


public class Warehouse 
{
	
	public UnityEvent ResourceChanged;

	public Dictionary<ResourceType, int> resources;

	private void Start()
	{
		resources = new Dictionary<ResourceType, int>();
		resources.Add(ResourceType.Money, 0);
		resources.Add(ResourceType.Wood, 0);
		resources.Add(ResourceType.Stone, 0);
		resources.Add(ResourceType.Iron, 0);
	}

	public bool SpendResource(ResourceType resourceType, int amount)
	{
		if (resources[resourceType] >= amount)
		{
			resources[resourceType] -= amount;
			return true;
		}
		else
		{
			return false;
		}
	}

	public void AddResource(ResourceType resourceType, int amount)
	{
		resources[resourceType] += amount;
		ResourceChanged?.Invoke();
	}


}
