using UnityEngine;
using UnityEngine.UI;

public class ToggleUIVisibility : MonoBehaviour
{
	public GameObject uiObject;

	public float raycastDistance = 10f;
	public LayerMask layerMask;

	void Update()
	{
		Vector2 raycastDirection = transform.right;
		RaycastHit2D hit = Physics2D.Raycast(transform.position, raycastDirection, raycastDistance, layerMask);

		if (hit.collider != null)
		{
			ToggleVisibility();
		}
	}
	
	public void ToggleVisibility()
	{
		uiObject.SetActive(!uiObject.activeSelf);
	}
}