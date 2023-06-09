using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CoroutineExecuter : MonoBehaviour
{
	private static CoroutineExecuter instance {
		get {
			if (_instance == null) {
				var corObject = new GameObject ("CoroutineExecuter").
					AddComponent<CoroutineExecuter>();
				_instance = corObject;
				DontDestroyOnLoad(corObject);
			}
			return _instance;
		}
	
	}
	
	private static CoroutineExecuter _instance;
	
	
	public static Coroutine StartRoutine(IEnumerator enumerator)
	{
		return instance.StartCoroutine(enumerator);
	}
	
	public void  StopRoutine(Coroutine routine)
	{
		instance.StopCoroutine(routine);
	}	
	
	//instance.StartCoroutine(NeedsDelay(() =>
	//{
	//	Debug.Log("Delay has finished");
	//}));

	


}
