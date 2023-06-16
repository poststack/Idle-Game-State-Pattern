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
	//input
	public ResourceType[] inputResourceType;
	public int[] inputResourceCount;
	
	//output
	public ResourceType[] outputResourceType;
	public int[] outputResourceCount;
	
	//time
	public float timeToProduce;
	public float timeToSwitch;
}
