using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateUi : MonoBehaviour
{
	private GameObject[] towersBlue;
	private GameObject[] towersRed;
	private GameObject[] phoenixBlue;
	private GameObject[] phoenixRed;
	[SerializeField] private TextMeshProUGUI textRed;
	[SerializeField] private TextMeshProUGUI textBlue;

	[HideInInspector] public int towersRedNum;
	[HideInInspector] public int phoenixRedNum;
	[HideInInspector] public int towersBlueNum;
	[HideInInspector] public int phoenixBlueNum;

	public static UpdateUi Instance { get; private set; }
	private void Awake()
	{
		if (Instance != null && Instance != this)
		{
			Destroy(this.gameObject);
			return;
		}
		Instance = this;
	}

    // Start is called before the first frame update
    void Start()
    {
		towersBlue = GameObject.FindGameObjectsWithTag("TowerBlue");
		towersRed = GameObject.FindGameObjectsWithTag("TowerRed");
		phoenixBlue = GameObject.FindGameObjectsWithTag("PhoenixBlue");
		phoenixRed = GameObject.FindGameObjectsWithTag("PhoenixRed");

		if (towersBlue.Length == 0)
		{
			Debug.LogWarning("No blue towers found");
		}
		if (towersRed.Length == 0)
		{
			Debug.LogWarning("No red towers found");
		}

		if (phoenixBlue.Length == 0)
		{
			Debug.LogWarning("No blue phoenix found");
		}
		if (phoenixRed.Length == 0)
		{
			Debug.LogWarning("No red phoenix found");
		}

		towersRedNum = towersRed.Length;
		phoenixRedNum = phoenixRed.Length;
		towersBlueNum = towersBlue.Length;
		phoenixBlueNum = phoenixBlue.Length;

		UpdateUI();
	}

	public void UpdateUI()
	{
		textRed.text = "Towers: " + towersRedNum + "\nPhoenix: " + phoenixRedNum;
		textBlue.text = "Towers: " + towersBlueNum + "\nPhoenix: " + phoenixBlueNum;
	}
}
