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
	
	 
	void Start()
	{
		if (!gameObject.GetComponent<ResourceSwitcher>().enabled)
		{
			objectNameUI.text = factory.factoryData.outputResourceType[0].ToString();
		}
	}
	
	

	
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
	
	
	public void ResetProductionView()
	{
		factory.productionProgress = 0;
		slider.value = 0;
		ArrowToWarehouseFillAmount.fillAmount = 0;

	}

}
