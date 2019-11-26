using UnityEngine;
using Vuforia;


public class destroyPhoenix : MonoBehaviour, IVirtualButtonEventHandler
{
	[SerializeField] private Material color;
	[SerializeField] private Material destroyedColor;
	[SerializeField] private bool red;

	public GameObject vbBtnObj;

	private bool isActive = true;
	private MeshRenderer mesh;

	// Start is called before the first frame update
	void Start()
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
		mesh = GetComponentInChildren<MeshRenderer>();
		if (mesh == null)
		{
			Debug.LogWarning("No mesh found");
		}
		else
		{
			if (isActive)
			{
				mesh.material = destroyedColor;
				isActive = false;
			}
			else
			{
				mesh.material = color;
				isActive = true;
			}
		}

		if (red)
		{
			if (isActive)
			{
				UpdateUi.Instance.phoenixRedNum++;
			}
			else
			{
				UpdateUi.Instance.phoenixRedNum--;
			}
		}
		else
		{
			if (isActive)
			{
				UpdateUi.Instance.phoenixBlueNum++;
			}
			else
			{
				UpdateUi.Instance.phoenixBlueNum--;
			}
		}
		UpdateUi.Instance.UpdateUI();
	}
}
