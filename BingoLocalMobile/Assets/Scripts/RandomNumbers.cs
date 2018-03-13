using System.Collections.Generic;
using UnityEngine;

public class RandomNumbers : MonoBehaviour {

	public House[] houses;
	List<int> numbersList;

	private void Start()
	{

		numbersList = new List<int>(houses.Length);
		int randomNumber;
		while (numbersList.Count < 36)
		{
			randomNumber = UnityEngine.Random.Range(0, 99);
			if (!numbersList.Contains(randomNumber))
			{
				numbersList.Add(randomNumber);
				houses[numbersList.Count - 1].SetNumber(randomNumber);
			}
		}


	}
}
