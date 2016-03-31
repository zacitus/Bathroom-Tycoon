using UnityEngine;
using System.Collections;

public class ObjectManager : MonoBehaviour {

	static public int rows = 11;
	static public int columns = 11;

	public GameObject tilePrefab;

	public Material owned;
	public Material forSale;
	public Material notForSale;
	public Material actionTrigger;

	public TileProperties tileprops;

	public GameObject[,] tileArray = new GameObject[rows, columns];



	void Awake ()
	{
	int i = 1;

		for (int x = 0; x < columns; x++)
		{
			for (int y = 0; y < rows; y++)
			{
				tileArray[x,y] = (Instantiate(tilePrefab, new Vector3(y, 0, -x), Quaternion.identity)) as GameObject;
				tileArray[x,y].GetComponent<TileProperties>().ID = i;
				i++;
			}

		}
		
	}

	// Use this for initialization
	void Start ()
	{

		// Divide the boy's and girl's restroom by dividing the map in half
		for (int i = 0; i < rows / 2; i++)
		{
			tileArray [rows/2, i].gameObject.GetComponent<Renderer> ().material = notForSale;
		}

	}
	// Update is called once per frame
	void Update () {

		// Make part of the map not for sale (yet)
		for (int x = columns - 1; x > -1; x--)
		{
			for (int y = rows - 1; y > 4; y--)
			{
				tileArray [x, y].gameObject.GetComponent<Renderer> ().material = notForSale;
			}
		}

	}
}
