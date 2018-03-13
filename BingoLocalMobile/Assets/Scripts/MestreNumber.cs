using UnityEngine;
using UnityEngine.UI;

public class MestreNumber : MonoBehaviour {

	public Text text;

	public void GetRandomNumber()
	{
		text.text = UnityEngine.Random.Range(0, 99).ToString();
	}
}
