using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseIUI : MonoBehaviour
{
	public GameObject ObjectToOpenClose;
	
	
	public void SwitchObject(bool enabled)
	{
		ObjectToOpenClose.SetActive(enabled);
	}
	
	public void toggle()
	{
		bool currentState = ObjectToOpenClose.activeSelf;

		//Flip it
		currentState = !currentState;

		//Set the current State to the flipped value
		ObjectToOpenClose.SetActive(currentState);

	}
}
