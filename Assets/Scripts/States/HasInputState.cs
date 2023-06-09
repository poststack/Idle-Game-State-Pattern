

public class HasInputState : BaseState
{
	public HasInputState(FactoryStateMachine factory): 
	base(factory)
	{
		
	}
	
	public override void Enter()
	{
		factory.SwitchState<WorkingState>();
	}
	public override void Exit()
	{
		
	}
	
	//input resource
	public override void LoadInput(){}
	public override void UnloadInput() {}

	//output resource
	public override void UnloadOutput(){}
}
