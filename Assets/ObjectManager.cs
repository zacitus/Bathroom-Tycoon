using UnityEngine;
using System.Collections;

public class ObjectManager : MonoBehaviour {

	static public int width = 11;
	static public int height = 11;

	public GameObject tilePrefab;

	public Material owned;
	public Material forSale;
	public Material notForSale;
	public Material actionTrigger;

	public GameObject[,] tileArray = new GameObject[width, height];



	void Awake ()
	{

		int i = 0;

		for (int y = 0; y < height; y++)
		{
			for (int x = 0; x < width; x++)
			{
				tileArray [x, y] = (Instantiate (tilePrefab, new Vector3 (x, 0, y), Quaternion.identity)) as GameObject;
				tileArray [x, y].GetComponent<TileProperties> ().ID = i;

				if (i > 77)
				{
					tileArray [x, y].GetComponent<Renderer> ().material = notForSale;
				}

				i++;
			}

		}
		
	}

	// Use this for initialization
	void Start ()
	{
	/*
		// Divide the boy's and girl's restroom by dividing the map in half
		for (int i = 0; i < width / 2; i++)
		{
			tileArray [width/2, i].gameObject.GetComponent<Renderer> ().material = notForSale;
		}
		*/
	}
	// Update is called once per frame
	void Update () {
	/*
		// Make part of the map not for sale (yet)
		for (int x = height - 1; x > -1; x--)
		{
			for (int y = width - 1; y > 4; y--)
			{
				tileArray [x, y].gameObject.GetComponent<Renderer> ().material = notForSale;
			}
		}
		*/
	}

}
