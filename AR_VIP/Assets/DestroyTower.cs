using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTower : MonoBehaviour
{
	public GameObject[] destroyObjects;
	public void Destroy()
	{
		foreach (GameObject destroy in destroyObjects)
		{
			destroy.SetActive(false);
		}
	}

	public void Create()
	{
		foreach (GameObject destroy in destroyObjects)
		{
			destroy.SetActive(true);
		}
	}
}
