

public abstract class BaseState
{
	//protected string stateName;
	protected string InfoString;
	protected FactoryData factory;
	protected FactoryStateMachine factoryController;
	protected Warehouse warehouse;
	
	//input
	protected ResourceType inputResourceType;
	protected int inputResourceCount;
	
	//output
	protected ResourceType outputResourceType;
	protected int outputResourceCount;
	
	//time
	protected float timeToProduce;
	
	
	public BaseState(
		FactoryStateMachine factoryParameter
		)
	{
		//stateName = stateName;
		//InfoString = InfoString;
		factoryController = factoryParameter;
		warehouse = factoryController.warehouse;
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
