

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
		//factory.DebugLog(_stateSwitcher.ToString());
		if (warehouse.CanSpendResource
			(inputResourceType,inputResourceCount)== true)
		{
			factoryController.SwitchState<HasInputState>();
		}
		else
		{
			//just idle
			//factory.SwitchState<IdleState>();
		}
	}
	
	//input resource
	public override void LoadInput(){}
	public override void UnloadInput() {}

	//output resource
	public override void UnloadOutput(){}
}
