

public abstract class BaseState
{
	//protected string stateName;
	protected string InfoString;
	protected FactoryStateMachine factory;
	protected Warehouse warehouse;
	protected IStateSwitcher _stateSwitcher;
	
	//input
	protected ResourceType inputResourceType;
	protected int inputResourceCount;
	
	//output
	protected ResourceType outputResourceType;
	protected int outputResourceCount;
	
	//time
	protected float timeToProduce;
	
	
	public BaseState(
		FactoryStateMachine factory
		)
	{
		//stateName = stateName;
		//InfoString = InfoString;
		factory = factory;
		warehouse = factory.warehouse;
		_stateSwitcher = factory.stateSwitcher;
		inputResourceType = factory.inputResourceType;
		inputResourceCount = factory.inputResourceCount;
		outputResourceType = factory.outputResourceType;
		outputResourceCount = factory.outputResourceCount;
		timeToProduce = factory.timeToProduce;
	}
	
	public abstract void Enter();
	public abstract void Exit();
	
	//input resource
	public abstract void LoadInput();
	public abstract void UnloadInput();

	//output resource
	public abstract void UnloadOutput();

}
