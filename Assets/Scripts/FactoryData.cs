using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryData 
{
	//input
	public ResourceType inputResourceType;
	public int inputResourceCount;
	
	//output
	public ResourceType outputResourceType;
	public int outputResourceCount;
	
	//time
	public float timeToProduce;
	public float timeToSwitch;
}
