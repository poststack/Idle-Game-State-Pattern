



public class WorkingState : BaseState
{
	public WorkingState(FactoryStateMachine factory): 
		base(factory)
	{
		
	}

	public override void Enter()
	{
		LoadInput();
		factory.StartProduction(factory.timeToProduce);
	}
	
	

	
	public override void Exit()
	{
		if (factory.productionProgress == 1)
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
		factory.warehouse.SpendResource
			(inputResourceType,inputResourceCount);
	}
	public override void UnloadInput() {}

	//output resource
	public override void UnloadOutput(){
		factory.warehouse.AddResource
		(factory.outputResourceType,
		 factory.outputResourceCount);
	}
}
