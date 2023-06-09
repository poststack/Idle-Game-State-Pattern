using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactoryProgressView : MonoBehaviour
{
	public float progress; //0 - 100
	public Slider slider;
	public FactoryStateMachine factory;
	
	
	public void StartProduction(float duration)
	{
		StartCoroutine(AnimateSlider(duration));

	}
	
	IEnumerator AnimateSlider(float duration)
	{
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			float lerpValue = time / duration;
			slider.value = Mathf.Lerp(0f, 1f, lerpValue);
			yield return null;
		}
		factory.SwitchState<NoInputState>();
	}



}
