using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

	public bool objectSelected = false;
	public string objectName;
	public string objectCost;
	public GameObject pendingObject;

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


		//this is the code that works, these 2 lines
		float height = savedObject.GetComponent<Renderer> ().bounds.size.y;
		Debug.Log ("The height is" + height);

		//float otherheight = savedObject.GetComponent<Renderer>().bounds.size.x;
		//Debug.Log(otherheight);

		//float otherotherheight = savedObject.GetComponent<Renderer>().bounds.size.z;
		//Debug.Log("The dumb height is" + otherotherheight);

		// Adjust for height
		//Vector3 fixedHeight = new Vector3 (targetObject.GetComponent<Transform>().position.x, (targetObject.GetComponent<Transform>().position.y + (height/4)), targetObject.GetComponent<Transform>().position.z);
		Vector3 fixedHeight = new Vector3 (targetObject.GetComponent<Transform> ().position.x, (targetObject.GetComponent<Transform> ().position.y + (height / 2)), targetObject.GetComponent<Transform> ().position.z);



		// Spawn the object
		pendingObject = Instantiate (savedObject, fixedHeight, Quaternion.Euler (0, 0, 0)) as GameObject;

		Color alphaColor = GetComponent<Renderer>().material.color;
		alphaColor.a = 0.3f;

		pendingObject.GetComponent<Renderer>().material.SetFloat("_Mode", 3);
		pendingObject.GetComponent<Renderer>().material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
		pendingObject.GetComponent<Renderer>().material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
		pendingObject.GetComponent<Renderer>().material.SetInt("_ZWrite", 0);
		pendingObject.GetComponent<Renderer>().material.DisableKeyword("_ALPHATEST_ON");
		pendingObject.GetComponent<Renderer>().material.DisableKeyword("_ALPHABLEND_ON");
		pendingObject.GetComponent<Renderer>().material.EnableKeyword("_ALPHAPREMULTIPLY_ON");
		pendingObject.GetComponent<Renderer>().material.renderQueue = 3000;

		pendingObject.GetComponent<Renderer>().material.color = alphaColor;
		pendingObject.GetComponent<Renderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;


		//targetObject.GetComponent<TileProperties>().tileLeft.GetComponent<Renderer>().material.color = Color.red;
		/*foreach (GameObject o in targetObject.GetComponent<TileProperties>().nearbyTilesList)
		{
			o.GetComponent<BounceObject>().AroundTheWorld = false;
			o.GetComponent<BounceObject>().Move = true;
		}*/

	}
}
