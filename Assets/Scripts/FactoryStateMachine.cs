using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FactoryStateMachine : MonoBehaviour
{
	[SerializeField]
	public bool isSwitchedOn;
	[Space(10)]
	
	public Warehouse warehouse;
	
	public FactoryProgressView view;
	
	public FactoryData factoryData;
	
	//________________________________
	//ДАЛЕЕ ДОЛЖНО БЫТЬ ТАК
	//public int MyProperty { get; private set; }
	//НО МНЕ ЛЕНЬ
	//________________________________
	
	
	////input
	//[SerializeField]
	//public ResourceType inputResourceType;
	//[SerializeField]
	//public int inputResourceCount;
	
	////output
	//[SerializeField]
	//public ResourceType outputResourceType;
	//[SerializeField]
	//public int outputResourceCount;
	
	////time
	//[SerializeField]
	//public float timeToProduce;
	//[SerializeField]
	//public float timeToSwitch;
	[SerializeField]
	public float productionProgress;
	
	[SerializeField]
	public BaseState currentState;
	[SerializeField]
	public string currentStateString;
	//public float[] values;

	[SerializeField]
	public BaseState[] allStates = new BaseState[4];
	
	private void Start()
	{
		//Console.Log("Enter IdleState");
		//0 - idle
		//1 - noInput
		//2 - hasInput
		//3 - Work
		allStates[0] = new IdleState(this);
		allStates[1] = new NoInputState(this);
		allStates[2] = new HasInputState(this);
		allStates[3] = new WorkingState(this);
		
		currentState = allStates[0];
		DebugLog("Enter State" + currentState.ToString());;
		currentState.Enter();
		
		//UI
		view.updateUI();
		view.updateButtonUI();
	}
	
	public void StartProduction(float duration)
	{
		StartCoroutine(productionRoutine(duration));
	}
	
	IEnumerator productionRoutine(float duration)
	{
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			float lerpValue = time / duration;
			productionProgress = Mathf.Lerp(0f, 1f, lerpValue);
			yield return new WaitForEndOfFrame();
			view.updateUI();
		}
		SwitchState<NoInputState>();
	}
	

	
	
	
	
	public void SwitchState<T>() where T : BaseState 
	{
		
		//DebugLog("SwitchState Invoked");
		var state = allStates.FirstOrDefault(s => s is T);
		StartCoroutine(switchingRoutine(factoryData.timeToSwitch, state));

	}
	
	
	
	IEnumerator switchingRoutine(float duration, BaseState state )
	{
		currentState.Exit();
		DebugLog("Exit State" + currentState.ToString());;
		currentState = state;
		yield return new WaitForSeconds (duration);
		currentStateString = currentState.ToString();
		currentState.Enter();
		DebugLog("Enter State" + currentState.ToString());;

		view.updateUI();

	}	
	
	public void DebugLog(string stringToShow )
	{
		Debug.Log(gameObject.name + " " + stringToShow);
	}

	public void StartFactory()
	{
		SwitchState<NoInputState>();
		isSwitchedOn = true;
	}
	
	public void StopFactory()
	{
		SwitchState<IdleState>();
		isSwitchedOn = false;
		StopAllCoroutines();
		productionProgress = 0;
		view.updateUI();
	}


}
