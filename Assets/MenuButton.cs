using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

	bool menuOpen = false;
	public GameObject[] uiElements;
	public GameObject[] menuButtons;

	// Use this for initialization
	void Start () {
		menuButtons = GameObject.FindGameObjectsWithTag ("Menu");
		foreach (GameObject menuButton in menuButtons)
			{
				menuButton.SetActive(false);



			}
	}

	public void MenuStateSwitcher ()
	{
		int x = 0;

		if (menuOpen == false)
		{
			foreach (GameObject menuButton in menuButtons)
			{
				menuButton.SetActive (true);
				x++;
				//Debug.Log("x is " + x + " and the List Length is "+ menuButtons.Length);

				if (x == menuButtons.Length)
				{
					Collapsible[] uiElements = FindObjectsOfType(typeof(Collapsible)) as Collapsible[];
					foreach (Collapsible uiElement in uiElements)
					{
						uiElement.GetComponent<Bounce>().timeToLeave = false;
					}

					menuOpen = true;
				}
			}
		}

		else if (menuOpen == true)
		{
			foreach (GameObject menuButton in menuButtons)
			{
				Collapsible[] uiElements = FindObjectsOfType(typeof(Collapsible)) as Collapsible[];
				foreach (Collapsible uiElement in uiElements)
				{
					uiElement.GetComponent<Bounce>().timeToLeave = true;
				}
			}
			menuOpen = false;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
