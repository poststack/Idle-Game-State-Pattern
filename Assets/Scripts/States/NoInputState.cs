

public class NoInputState : BaseState
{
	
	
	
	public NoInputState(FactoryStateMachine factory): 
	base(factory)
	{
		
	}
	
	public override void Enter()
	{
		
		//подписаться на WarehouseChange
		warehouse.OnResourceChanged += CheckInput;
		//factory.AddToDebug("Enter NoInputState");
		CheckInput();
	}

	public override void Exit()
	{
		//отписаться от WarehouseChange
		warehouse.OnResourceChanged -= CheckInput;
	}
	
	public void CheckInput()
	
	{
		//Проверить все 
		if (CheckResources(factory.inputResources))
		{
			factoryController.SwitchState<HasInputState>();
		}
		else
		{
			//just idle
			//factory.SwitchState<IdleState>();
		}
	}
	
	private bool CheckResources(Resource[] requiredResources)
	{
		return warehouse.CanSubtractMultipleResource(requiredResources);
	}	
	
	//input resource
	public override void LoadInput(){}
	public override void UnloadInput() {}

	//output resource
	public override void UnloadOutput(){}
}
