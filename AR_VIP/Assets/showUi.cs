using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class showUi : MonoBehaviour, IVirtualButtonEventHandler
{
	public GameObject vbBtnObj;
	public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		Debug.Log("called");
		switchCanvas();
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{

	}

	private void switchCanvas()
	{
		canvas.SetActive(!canvas.activeSelf);
	}
}
