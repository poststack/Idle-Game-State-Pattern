

public abstract class BaseState
{
	protected string stateName;
	protected string InfoString;
	protected FactoryStateMachine factory;
	protected Warehouse warehouse;
	protected IStateSwitcher stateSwitcher;
	
	//input
	protected ResourceType inputResourceType;
	protected int inputResourceCount;
	
	//output
	protected ResourceType outputResourceType;
	protected int outputResourceCount;
	
	//time
	protected float timeToProduce;
	
	
	public BaseState(
		string stateName,
		string InfoString,
		FactoryStateMachine factory,
		Warehouse warehouse,
		IStateSwitcher stateSwitcher,
		ResourceType inputResourceType,
		int inputResourceCount,
		ResourceType outputResourceType,
		int outputResourceCount,
		float timeToProduce
		)
	{
		stateName = stateName;
		InfoString = InfoString;
		factory = factory;
		warehouse = warehouse;
		stateSwitcher = stateSwitcher;
		inputResourceType = inputResourceType;
		inputResourceCount = inputResourceCount;
		outputResourceType = outputResourceType;
		outputResourceCount = outputResourceCount;
		timeToProduce = timeToProduce;
	}
	
	public abstract void Enter();
	public abstract void Exit();
	
	//input resource
	public abstract void LoadInput();
	public abstract void UnloadInput();

	//output resource
	public abstract void UnloadOutput();

}
