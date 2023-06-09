



public class WorkingState : BaseState
{
	public WorkingState(FactoryStateMachine factory): 
		base(factory)
	{
		
	}

	public override void Enter()
	{
		warehouse.SpendResource(
			inputResourceType,inputResourceCount);
		factory.view.StartProduction(factory.timeToProduce);
	}
	
	

	
	public override void Exit()
	{
		UnloadOutput();
		
	}
	





	//input resource
	public override void LoadInput(){}
	public override void UnloadInput() {}

	//output resource
	public override void UnloadOutput(){
		factory.warehouse.AddResource
			(outputResourceType,outputResourceCount);
	}
}
