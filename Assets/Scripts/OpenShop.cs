using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class OpenShop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoToShop ()
	{
		CanvasRenderer[] uiElements = FindObjectsOfType(typeof(CanvasRenderer)) as CanvasRenderer[];
		foreach (CanvasRenderer uiElement in uiElements)
		{
			uiElement.GetComponent<Bounce>().timeToLeave = true;
		}

		StartCoroutine("Wait");
	}

	void LoadLevel()
    {
    	Debug.Log("Load the level!");
		SceneManager.LoadScene("ShopMenu", LoadSceneMode.Additive);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.6f);
        LoadLevel();
    }
}
