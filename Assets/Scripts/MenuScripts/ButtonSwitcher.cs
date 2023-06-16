using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitcher : MonoBehaviour 
{
	public int levelNumber;
	
	public Button button1;
	public Button button2;
	public Button button3;
	public GameObject object1;
	public GameObject object2;
	public GameObject object3;

	void Start() 
	{
		button1.onClick.AddListener(Button1Clicked);
		button2.onClick.AddListener(Button2Clicked);
		button3.onClick.AddListener(Button3Clicked);
		Button1Clicked();
	}

	void Button1Clicked() 
	{
		object1.SetActive(true);
		object2.SetActive(false);
		object3.SetActive(false);
		levelNumber = 1;
	}

	void Button2Clicked() 
	{
		object1.SetActive(false);
		object2.SetActive(true);
		object3.SetActive(false);
		levelNumber = 2;
	}

	void Button3Clicked() 
	{
		object1.SetActive(false);
		object2.SetActive(false);
		object3.SetActive(true);
		levelNumber = 3;
	}
}

