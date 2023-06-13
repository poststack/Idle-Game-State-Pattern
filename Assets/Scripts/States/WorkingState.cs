



public class WorkingState : BaseState
{
	public WorkingState(FactoryStateMachine factory): 
		base(factory)
	{
		
	}

	public override void Enter()
	{
		LoadInput();
		factoryController.StartProduction(factory.timeToProduce);
	}
	
	

	
	public override void Exit()
	{
		if (factoryController.productionProgress == 1)
		{
			UnloadOutput();
		}
		else
		{
			//resource waisted
		}
		
		
		
		
	}
	
	
	





	//input resource
	public override void LoadInput()
	{
		factoryController.warehouse.SpendResource
			(inputResourceType,inputResourceCount);
	}
	public override void UnloadInput() {}

	//output resource
	public override void UnloadOutput(){
		factoryController.warehouse.AddResource
		(factory.outputResourceType,
		 factory.outputResourceCount);
	}
}
