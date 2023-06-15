using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;


public class ResourceSwitcher : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	public FactoryData factory;
	
	public Sprite[] sprites;
	public Image image;
	public TextMeshProUGUI ResourceName;
	[Space (20)]
	[Header ("LImits")]
	public int lowLimit;
	public int upLimit;

	private int currentIndex = 0;

	private bool isMouseOver = false;

	protected void Start()
	{
		currentIndex = lowLimit;
		DoSwitch();
	}

	private void Update()
	{
		if (!isMouseOver) return;

		float scroll = Input.GetAxis("Mouse ScrollWheel");

		if (scroll > 0f)
		{
			SwitchDown();
		}
		else if (scroll < 0f)
		{
			SwitchUp();
		}
		
	}
	
	public void SwitchUp()
	{
		currentIndex++;
		if (currentIndex >= upLimit) currentIndex = lowLimit;
		DoSwitch();
	}
	
	public void SwitchDown()
	{
		currentIndex--;
		if (currentIndex < lowLimit) currentIndex = upLimit - 1;
		DoSwitch();
	}
	
	private void DoSwitch()
	{
		image.sprite = sprites[currentIndex];
		ResourceName.text = GetEnumStringByIndex(currentIndex);
		factory.outputResourceType = GetEnumValueByIndex(currentIndex);

	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		isMouseOver = true;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		isMouseOver = false;
	}
	
	
	
	private ResourceType GetEnumValueByIndex(int index)
	{
		ResourceType result = ResourceType.Iron;
		ResourceType[] enumValues = (ResourceType[])System.Enum.GetValues(typeof(ResourceType));
		if (index >= 0 && index < enumValues.Length)
		{
			result = enumValues[index];
		}
		else
		{
			Debug.LogError("Invalid index for enum value.");
		}
		return result;
	}
	
	private string GetEnumStringByIndex(int index)
	{
		string result = "error in GetEnumValueByIndex(int index)";
		ResourceType[] enumValues = (ResourceType[])System.Enum.GetValues(typeof(ResourceType));
		if (index >= 0 && index < enumValues.Length)
		{
			result = enumValues[index].ToString();
			//Debug.Log("Loaded color: " + result);
		}
		else
		{
			Debug.LogError("Invalid index for enum value.");
		}
		return result;
	}
}