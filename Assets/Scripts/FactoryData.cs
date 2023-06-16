using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryData : MonoBehaviour
{
	//________________________________
	//ДАЛЕЕ ДОЛЖНО БЫТЬ ТАК
	//public int MyProperty { get; private set; }
	//НО МНЕ ЛЕНЬ
	//________________________________
	
	
	
	public string factoryName;
	//МНЕ СТЫДНО, НО Я НЕ ЗНАЮ, КАК ПОКАЗАТЬ ТИП 
	//Resource В ИНСПЕКТОРЕ 
	//input
	public Resource[] inputResources;
	public ResourceType[] inputResourceType;
	public int[] inputResourceCount;
	
	//output
	public Resource[] outputResources;
	public ResourceType[] outputResourceType;
	public int[] outputResourceCount;
	
	//time
	public float timeToProduce;
	public float timeToSwitch;
	
	protected void Start()
	{
		inputResources = new Resource[inputResourceType.Length];
		for (int i = 0; i < inputResourceType.Length; i++)
		{
			inputResources[i] = new Resource(inputResourceType[i], inputResourceCount[i]);
		}
		
		outputResources = new Resource[outputResourceType.Length];
		for (int i = 0; i < outputResourceType.Length; i++)
		{
			outputResources[i] = new Resource(outputResourceType[i], outputResourceCount[i]);
		}
		
	}
}
