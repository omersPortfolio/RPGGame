using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace RPG.SceneManagement
{
	public class MainMenu : MonoBehaviour
	{
		public void StartGame()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			Time.timeScale = 1;
		}

		public void ExitGame()
		{
			Application.Quit();
		}
	}
}