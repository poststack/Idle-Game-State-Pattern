

public class IdleState : BaseState
{
	public IdleState()
	{
	
	}

	public override void Enter()
	{
		//надпись старт <- стоп

	}
	public override void Exit()
	{
		//надпись старт -> стоп
		//stateSwitcher.SwitchState<NoInputState>();

	}

	//input resource
	public override void LoadInput()
	{
		InfoString = "нет необходимости загружать ресурсы";
	}
	public override void UnloadInput();

	//output resource
	public override void UnloadOutput();
}
