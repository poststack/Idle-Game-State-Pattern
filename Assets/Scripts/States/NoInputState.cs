

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
	}

	public override void Exit()
	{
		//отписаться от WarehouseChange
		warehouse.ResourceChanged -= CheckInput;
	}
	
	public void CheckInput()
	{
		if (warehouse.CanSpendResource
			(inputResourceType,inputResourceCount)== true)
		{
			_stateSwitcher.SwitchState<HasInputState>();
		}
	}
	
	//input resource
	public override void LoadInput(){}
	public override void UnloadInput() {}

	//output resource
	public override void UnloadOutput(){}
}
