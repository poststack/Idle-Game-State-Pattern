

public class NoInputState : BaseState
{
	
	
	public NoInputState()
	{
		
	}
	
	public override void Enter()
	{
		//подписаться на WarehouseChange
		warehouse.ResourceChanged += CheckInput();
	}

	public override void Exit()
	{
		//отписаться от WarehouseChange
		warehouse.ResourceChanged -= CheckInput();
	}
	
	public void CheckInput()
	{
		if (warehouse.SpendResource
			(inputResourceType,inputResourceCount)== true)
		{
			stateSwitcher.SwitchState<HasInputState>();
		}
	}
	
	//input resource
	public override void LoadInput();
	public override void UnloadInput();

	//output resource
	public override void UnloadOutput();
}
