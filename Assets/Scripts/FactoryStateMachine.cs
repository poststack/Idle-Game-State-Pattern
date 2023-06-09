using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FactoryStateMachine : MonoBehaviour, IStateSwitcher
{
	[SerializeField]
	public Warehouse warehouse;
	
	//________________________________
	//ДАЛЕЕ ДОЛЖНО БЫТЬ ТАК
	//public int MyProperty { get; private set; }
	//НО МНЕ ЛЕНЬ
	//________________________________
	
	[SerializeField]
	public IStateSwitcher stateSwitcher;
	
	//input
	[SerializeField]
	public ResourceType inputResourceType;
	[SerializeField]
	public int inputResourceCount;
	
	//output
	[SerializeField]
	public ResourceType outputResourceType;
	[SerializeField]
	public int outputResourceCount;
	
	//time
	[SerializeField]
	public float timeToProduce;
	[SerializeField]
	public float productionProgress;
	
	private BaseState currentState;
	//public float[] values;

	private BaseState[] allStates = new BaseState[4];
	
	private void Start()
	{
		//0 - idle
		//1 - noInput
		//2 - hasInput
		//3 - Work
		//allStates[0] = new 
	}
	
	public void SwitchState<T>() where T : BaseState 
	{
		var state = allStates.FirstOrDefault(s => s is T);
		currentState.Exit();
		currentState = state;
		currentState.Enter();
		
	}



}
