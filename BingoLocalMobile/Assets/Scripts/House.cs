using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour {

	public Text text;
	Image img;

	private void Start()
	{
		img = GetComponent<Image>();
		
	}

	public void SetNumber(int number)
	{
		text.text = number.ToString();
	}


	public void ChangeColor()
	{
		if (img.color == Color.white)
		{
			img.color = Color.yellow;
		}
		else
		{
			img.color = Color.white;
		}
	}
}
