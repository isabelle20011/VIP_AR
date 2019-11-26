using UnityEngine;
using Vuforia;

public class DestroyTower : MonoBehaviour, IVirtualButtonEventHandler
{
	[SerializeField] private GameObject[] destroyObjects;
	public GameObject vbBtnObj;
	[SerializeField] private bool red;

	private void Start()
	{
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		DestroyCreate();
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

		if (red)
		{
			if (destroyObjects[0].activeSelf)
			{
				UpdateUi.Instance.towersRedNum++;
			}
			else
			{
				UpdateUi.Instance.towersRedNum--;
			}
		}
		else
		{
			if (destroyObjects[0].activeSelf)
			{
				UpdateUi.Instance.towersBlueNum++;
			}
			else
			{
				UpdateUi.Instance.towersBlueNum--;
			}
		}
		UpdateUi.Instance.UpdateUI();
	}
}
