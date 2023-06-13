

public class IdleState : BaseState
{
	public IdleState(FactoryStateMachine factory): 
	base(factory)
	{
		
	}

	public override void Enter()
	{
		factoryController.DebugLog("test");

	}
	public override void Exit()
	{

	}

	//input resource
	public override void LoadInput()
	{
		InfoString = "нет необходимости загружать ресурсы";
	}
	public override void UnloadInput()
	{
		
	}

	//output resource
	public override void UnloadOutput()
	{
		
	}
}
