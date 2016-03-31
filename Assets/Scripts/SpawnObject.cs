using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

	public bool objectSelected = false;
	public string objectName;
	public string objectCost;

	public GameObject savedObject;

	public ColorHighlight ColorHighlightScript;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void PlaceObject (GameObject targetObject)
	{
		// Get the SavedObject's height
		//float debugheight = savedObject.GetComponent<Transform>().lossyScale.y;
		//float debugheight = savedObject.GetComponent<MeshRenderer>().bounds.size.y;
		//float debugheight = savedObject.GetComponent<Renderer>().bounds.min.y;
		//Debug.Log("The test height is" + debugheight);

		float height = savedObject.GetComponent<Renderer>().bounds.size.y;
		Debug.Log("The height is" + height);

		//float otherheight = savedObject.GetComponent<Renderer>().bounds.size.x;
		//Debug.Log(otherheight);

		//float otherotherheight = savedObject.GetComponent<Renderer>().bounds.size.z;
		//Debug.Log("The dumb height is" + otherotherheight);

		// Adjust for height
		//Vector3 fixedHeight = new Vector3 (targetObject.GetComponent<Transform>().position.x, (targetObject.GetComponent<Transform>().position.y + (height/4)), targetObject.GetComponent<Transform>().position.z);
		Vector3 fixedHeight = new Vector3 (targetObject.GetComponent<Transform>().position.x, (targetObject.GetComponent<Transform>().position.y + (height/2)), targetObject.GetComponent<Transform>().position.z);



		// Spawn the object
		Instantiate (savedObject, fixedHeight, Quaternion.Euler(0, 0, 0));
		//Instantiate (savedObject, targetObject.GetComponent<Transform>().position, Quaternion.Euler(-90, 0, 0));
	}
}
