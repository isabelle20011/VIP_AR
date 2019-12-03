using UnityEngine;
using TMPro;

public class AddCharacterDetail : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI Name;
	[SerializeField] private TextMeshProUGUI Class;
	[SerializeField] private TextMeshProUGUI Pros;
	[SerializeField] private TextMeshProUGUI Difficulty;
	[SerializeField] private TextMeshProUGUI Pantheon;
	[SerializeField] private TextMeshProUGUI Abilities;

	[SerializeField] private string s_name;
	[SerializeField] private string s_class;
	[SerializeField] private string s_pros;
	[SerializeField] private string s_difficulty;
	[SerializeField] private string s_pantheon;
	[SerializeField] private string s_abilities;

	private void Start()
    {
		Name.text = s_name;
		Class.text += s_class;
		Pros.text += s_pros;
		Difficulty.text += s_difficulty;
		Pantheon.text += s_pantheon;
		Abilities.text += s_abilities;
    }
}
