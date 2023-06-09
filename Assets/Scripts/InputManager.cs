using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class InputManager : MonoBehaviour
{
	[SerializeField]
	private FactoryStateMachine factory1, factory2;
	
	[Button("$ButtonName")]
	public void StartFactory1()
	{
		factory1.SwitchState<NoInputState>();
	}
}
