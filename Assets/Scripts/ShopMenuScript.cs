using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ShopMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoToGame ()
	{

		

		CanvasRenderer[] uiElements = FindObjectsOfType (typeof(CanvasRenderer)) as CanvasRenderer[];
		foreach (CanvasRenderer uiElement in uiElements)
		{
			if (uiElement.GetComponent<Bounce>() != null)
			{
				uiElement.GetComponent<Bounce> ().timeToLeave = true;
			}
		}

		StartCoroutine("Wait");
	}

	void LoadLevel()
    {
		SceneManager.UnloadScene("ShopMenu");

		GameObject tempObject =  GameObject.Find("SceneWatcher");
		tempObject.GetComponent<SceneWatcherScript>().sceneHasUnloaded = true;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.6f);
        LoadLevel();
    }

}