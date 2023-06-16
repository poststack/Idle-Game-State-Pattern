using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using DamageNumbersPro;



public class Warehouse : MonoBehaviour
{
	
	[SerializeField]
	private bool useCheat;
	
	[SerializeField]
	private WareHouseView view;
	public UnityAction  OnResourceChanged;
	
	public GameObject AddStockObject;
	public DamageNumber goodFloatingNumbers;
	public DamageNumber badFloatingNumbers;



	[Space (10)]
	public List<Resource> resources = new List<Resource>();

	


	protected void Start()
	{
		InitilizeWarehouse();
	}
	 private void InitilizeWarehouse()
	 {
		 for (int i = 0; i < System.Enum.GetValues(typeof(ResourceType)).Length; i++)
		 {
			 ResourceType type = (ResourceType)i;
			 resources.Add(new Resource(type, 0));
		 }
		 
		 //CHEAT
		 if (useCheat) AddResource(ResourceType.Money,1000);
	 }



	
	
	
	
	public void AddResource(ResourceType type, int amount)
	{
		Resource resource = resources.Find(r => r.Type == type);

		if (resource != null)
		{
			resource.AddAmount(amount);
			
			OnResourceChanged?.Invoke();
			
			if (badFloatingNumbers != null & amount != 0)
			{
				DamageNumber damageNumber = goodFloatingNumbers.Spawn
				(gameObject.transform.position,
					type.ToString() + " "
					+ amount.ToString());
			}
			view.updateInventoryUI( resource.Type,  resource.Amount);
		}
	}
	
	
	

	
	public bool CanSubtractResource(ResourceType type, int amount)
	{
		Resource resource = resources.Find(r => r.Type == type);

		if (resource != null)
		{
			return resource.Amount >= amount;
		}

		return false;
	}
	

	
	
	public void SubtractResource(ResourceType type, int amount)
	{
		Resource resource = resources.Find(r => r.Type == type);

		if (resource != null)
		{
			resource.SubtractAmount(amount);
			
			if (badFloatingNumbers != null & amount != 0)
			{
				DamageNumber damageNumber = badFloatingNumbers.Spawn
				(gameObject.transform.position,
					type.ToString() + " "
					+ amount.ToString());
			}
			view.updateInventoryUI( resource.Type,  resource.Amount);
		}
	}




	public bool CanSubtractMultipleResource(Resource[] requiredResources)
	{
		foreach (var requiredResource in requiredResources)
		{
			if (!CanSubtractResource(requiredResource.Type, requiredResource.Amount) )
			{
				return false;
			}
		}

		return true;
	}

	public void SubtractMultipleResource(Resource[] requiredResources)
	{
		foreach (var requiredResource in requiredResources)
		{
			SubtractResource(requiredResource.Type, requiredResource.Amount);
		}
	}


}
