using UnityEngine;
using System.Collections;

public class SceneWatcherScript : MonoBehaviour {

	public bool sceneHasUnloaded = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (sceneHasUnloaded)
		{
			CanvasRenderer[] uiElements = FindObjectsOfType (typeof(CanvasRenderer)) as CanvasRenderer[];
			foreach (CanvasRenderer uiElement in uiElements)
			{
				if (uiElement.GetComponent<Bounce> () != null)
				{
					uiElement.GetComponent<Bounce> ().timeToLeave = false;
				}
				sceneHasUnloaded = false;
			}
		}

	}
}
