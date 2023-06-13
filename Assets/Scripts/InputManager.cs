using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
	[SerializeField]
	private FactoryStateMachine factory1, factory2;
	
	public void StartFactory1()
	{
		factory1.SwitchState<NoInputState>();
	}
}
