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

	private int currentIndex = 0;

	private bool isMouseOver = false;

	protected void Start()
	{
		DoSwitch();
	}

	private void Update()
	{
		if (!isMouseOver) return;

		float scroll = Input.GetAxis("Mouse ScrollWheel");

		if (scroll > 0f)
		{
			currentIndex--;
			if (currentIndex < 0) currentIndex = sprites.Length - 1;
		}
		else if (scroll < 0f)
		{
			currentIndex++;
			if (currentIndex >= sprites.Length) currentIndex = 0;
		}
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