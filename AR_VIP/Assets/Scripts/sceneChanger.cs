﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
	public void changeScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
