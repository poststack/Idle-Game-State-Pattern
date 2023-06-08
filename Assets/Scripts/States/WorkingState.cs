
public class WorkingState : BaseState
{
	public WorkingState()
	{

	}

	public override void Enter()
	{
		bool _bool = warehouse.SpendResource(warehouse.SpendResource
		(inputResourceType,inputResourceCount));
	}
	public override void Exit()
	{
		//отписаться от WarehouseChange
	}

	IEnumerator Fade()
	{
		Color c = renderer.material.color;
		for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
		{
			c.a = alpha;
			renderer.material.color = c;
			yield return new WaitForSeconds(.1f);
		}
	}


	//input resource
	public override void LoadInput();
	public override void UnloadInput();

	//output resource
	public override void UnloadOutput();
}
