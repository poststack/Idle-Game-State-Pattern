

public class HasInputState : BaseState
{
	public HasInputState()
	{
		
	}
	
	public override void Enter()
	{
		stateSwitcher.SwitchState<WorkingState>();
	}
	public override void Exit()
	{
		
	}
	
	////input resource
	//public override void LoadInput();
	//public override void UnloadInput();

	////output resource
	//public override void UnloadOutput();
}
