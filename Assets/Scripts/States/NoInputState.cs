

public class NoInputState : BaseState
{
	
	
	
	public NoInputState(FactoryStateMachine factory): 
	base(factory)
	{
		
	}
	
	public override void Enter()
	{
		
		//подписаться на WarehouseChange
		warehouse.ResourceChanged += CheckInput;
		//factory.AddToDebug("Enter NoInputState");
		CheckInput();
	}

	public override void Exit()
	{
		//отписаться от WarehouseChange
		warehouse.ResourceChanged -= CheckInput;
	}
	
	public void CheckInput()
	
	{
		//Проверить все 
		if (warehouse.CanSpendResource
			(factory.inputResourceType[0],
			factory.inputResourceCount[0])
			== true)
		{
			factoryController.SwitchState<HasInputState>();
		}
		else
		{
			//just idle
			//factory.SwitchState<IdleState>();
		}
	}
	
	//private bool CheckResources(ResourceType[] requiredResources, int[] amounts)
	//{
	//	foreach (ResourceType resource in requiredResources)
	//	{
	//		if (resource.Amount > ResourceManager.Instance.GetResourceAmount(resource.Type))
	//		{
	//			return false;
	//		}
	//	}
	//	return true;
	//}	
	
	//input resource
	public override void LoadInput(){}
	public override void UnloadInput() {}

	//output resource
	public override void UnloadOutput(){}
}
