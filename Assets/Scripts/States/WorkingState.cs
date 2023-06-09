//using System.Collections;
//using System.Collections.Generic;

public class WorkingState : BaseState
{
	public WorkingState(FactoryStateMachine factory): 
		base(factory)
	{
		
	}

	public override void Enter()
	{
		warehouse.SpendResource(
			inputResourceType,inputResourceCount);

	}
	public override void Exit()
	{
		_stateSwitcher.SwitchState<NoInputState>();
	}




	//input resource
	public override void LoadInput(){}
	public override void UnloadInput() {}

	//output resource
	public override void UnloadOutput(){}
}
