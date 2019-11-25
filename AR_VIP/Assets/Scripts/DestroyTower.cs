using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DestroyTower : MonoBehaviour, IVirtualButtonEventHandler
{
	[SerializeField] private GameObject[] destroyObjects;
	[SerializeField] private string buttonName;
	public GameObject vbBtnObj;

	private void Start()
	{
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		DestroyCreate();
		Debug.Log(buttonName + " ran");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{

	}

	private void DestroyCreate()
	{
		foreach (GameObject destroy in destroyObjects)
		{
			destroy.SetActive(!destroy.activeSelf);
		}
	}
}
