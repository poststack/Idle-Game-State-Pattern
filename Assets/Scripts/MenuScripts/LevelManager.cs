using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour 
{
	public ButtonSwitcher selection;
	
	public void LoadLevel() 
	{
		SceneManager.LoadScene(selection.levelNumber);
	}

	public void ReturnToMainMenu() 
	{
		SceneManager.LoadScene("MainMenu");
	}
}

