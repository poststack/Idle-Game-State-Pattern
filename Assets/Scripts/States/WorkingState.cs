



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
		
		factoryController.ResetProdution();
		
		
	}
	
	
	





	//input resource
	public override void LoadInput()
	{
		factoryController.warehouse.SubtractMultipleResource(
			factory.inputResources);
	}
	public override void UnloadInput() {}

	//output resource
	public override void UnloadOutput(){
		factoryController.warehouse.AddResource
		(factory.outputResourceType[0],
		 factory.outputResourceCount[0]);
	}
}
