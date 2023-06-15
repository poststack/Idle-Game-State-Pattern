using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FactoryProgressView : MonoBehaviour
{
	//Progress
	public float progress; //0 - 100
	public Slider slider;
	public Image ArrowToWarehouseFillAmount;
	
	//other
	public TextMeshProUGUI objectNameUI;
	public TextMeshProUGUI currentStateUI;
	public TextMeshProUGUI buttonCaption;
	public FactoryStateMachine factory;
	
	 
	
	

	
	public void updateUI()
	{
		if (factory.currentState != null)
		{
			currentStateUI.text = factory.currentState.ToString();
		}
		slider.value = factory.productionProgress;		
		if (ArrowToWarehouseFillAmount != null)
		{
			ArrowToWarehouseFillAmount.fillAmount = factory.productionProgress;
		}
	}
	
	public void updateButtonUI()
	{
		string result = "error in ButtonCaption()";
		
		if (factory.isSwitchedOn)
		{
			result =  "Stop";
		}
		else
		{

			result =  "Start";
		}
		buttonCaption.text = result;

		
	}
	
	public void StartStopButtonAction()
	{
		if (factory.isSwitchedOn)
		{
			factory.StopFactory();
		}
		else
		{

			factory.StartFactory();
		}
		updateButtonUI();
	}

}
