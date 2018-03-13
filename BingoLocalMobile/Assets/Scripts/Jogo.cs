using UnityEngine;

public class Jogo : MonoBehaviour {

	public GameObject screenInitial;
	public GameObject screenUser;
	public GameObject screenMaster;
	
	private void Start()
	{
		screenInitial.SetActive(true);
		screenUser.SetActive(false);
		screenMaster.SetActive(false);
	}


	public void OpenInitialScreen()
	{
		screenInitial.SetActive(true);
		screenUser.SetActive(false);
		screenMaster.SetActive(false);

	}

	public void OpenUserScreen()
	{
		screenInitial.SetActive(false);
		screenUser.SetActive(true);
		screenMaster.SetActive(false);


	}

	public void OpenMasterScreen()
	{
		screenInitial.SetActive(false);
		screenUser.SetActive(false);
		screenMaster.SetActive(true);
	}

	

}
