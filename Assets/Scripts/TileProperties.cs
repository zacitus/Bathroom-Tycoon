using UnityEngine;
using System.Collections;

public class TileProperties : MonoBehaviour {

	public bool open = true;

	public int ID;

	public GameObject tileUpper;
	public GameObject tileLower;
	public GameObject tileLeft;
	public GameObject tileRight;

	public int tileUpperInt;
	public int tileLowerInt;
	public int tileLeftInt;
	public int tileRightInt;

	public GameObject tileUpperRight;
	public GameObject tileUpperLeft;
	public GameObject tileLowerRight;
	public GameObject tileLowerLeft;

	public int tileUpperRightInt;
	public int tileUpperLeftInt;
	public int tileLowerRightInt;
	public int tileLowerLeftInt;

	private GameObject ObjectManagerGameObject;

	public GameObject tempGameObject;

	// Use this for initialization
	void Start () {

		ObjectManagerGameObject = GameObject.Find("ObjectManager");

		int arrayWidth = ObjectManager.width;
		//Debug.Log("arrayWidth is " + arrayWidth);
		int arrayHeight = ObjectManager.height;
		//Debug.Log("arrayHeight is " + arrayHeight);

		tileUpperInt = ID + arrayWidth;
		tileLowerInt = ID - arrayWidth;
		tileLeftInt = ID - 1;
		tileRightInt = ID + 1;

		tileUpperRightInt = ID + arrayWidth + 1;
		tileUpperLeftInt = ID + arrayWidth - 1;
		tileLowerRightInt = ID - arrayWidth + 1;
		tileLowerLeftInt = ID - arrayWidth - 1;

		tileUpper = AssignTile(tileUpperInt);
		tileLower = AssignTile(tileLowerInt);
		tileLeft = AssignTile(tileLeftInt);
		tileRight = AssignTile(tileRightInt);
		tileUpperRight = AssignTile(tileUpperRightInt);
		tileUpperLeft = AssignTile(tileUpperLeftInt);
		tileLowerRight = AssignTile(tileLowerRightInt);
		tileLowerLeft = AssignTile(tileLowerLeftInt);
	}

	GameObject AssignTile (int tileNumber)

	{
		int arrayMax = ObjectManager.width * ObjectManager.height;

		if (tileNumber > arrayMax - 1 || tileNumber < 0)
		{
			return null;
		} 
		else if (tileNumber < ObjectManager.width - 1)
		{
			Debug.Log("Else if triggered!");

			return(ObjectManagerGameObject.GetComponent<ObjectManager> ().tileArray [(tileNumber), 0]);

		} 
		else if (tileNumber > ObjectManager.width - 1) {
			int remainder = tileNumber % ObjectManager.width;

			return(ObjectManagerGameObject.GetComponent<ObjectManager> ().tileArray [remainder, tileNumber/ObjectManager.width]);
		}
		else
		{
			return null;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
