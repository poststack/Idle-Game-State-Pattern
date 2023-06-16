using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchProduction : MonoBehaviour
{
	public GameObject[] objectsToCycle;
	private int currentIndex = 0;

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		CycleObjects();
	}
	
	
	public void CycleObjects()
	{
		foreach (GameObject obj in objectsToCycle)
		{
			obj.SetActive(false);
			obj.GetComponent<FactoryStateMachine>().SwitchState<IdleState>();
		}

		objectsToCycle[currentIndex].SetActive(true);
		currentIndex++;

		if (currentIndex >= objectsToCycle.Length)
		{
			currentIndex = 0;
		}
	}

}
