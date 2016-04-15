using UnityEngine;
using System.Collections;

public class ColorHighlight : MonoBehaviour {

	public SpawnObject spawnObjectScript;

	private Color startcolor;
	private bool inside = true;

	private float lerpAmount = 0;

	private bool isRising = false;
	private Color tempColor;

	private Color colorA;
	private Color colorB;

	public bool placingObject = false;

	public GameObject particle;

	//private Renderer clickedTile;


	void Start ()
	{
		spawnObjectScript = GetComponent<SpawnObject>();
	}

	void Update ()
	{

		for (int i = 0; i < Input.touchCount; ++i) {
            if (Input.GetTouch(i).phase == TouchPhase.Began) {
                
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

            }
        }

        // Color feeedback effect
		if (isRising == true)
		{
			tempColor = Color.Lerp (colorA, startcolor, lerpAmount);
			GetComponent<Renderer> ().material.color = tempColor;
			lerpAmount += Time.deltaTime;
			//Debug.Log ("Current lerp amount: " + lerpAmount);


			if (lerpAmount >= 1)
			{
				isRising = false;
				lerpAmount = 0;
			}
		}
	}

	#if UNITY_EDITOR

	void OnMouseDown ()
	{
		if ((inside) && (GetComponent<TileProperties> ().open == true) && (placingObject != true))
		{
			// If the tile is free, highlight it as green when clicked
			//GetComponent<Renderer> ().material.color = Color.green;

			//Renderer clickedTile = GetComponent<Renderer>();

			// Pass the GameObject to the SpawnObjectScript and spawn the prefab on top of the selected GameObject
			startcolor = GetComponent<Renderer> ().material.color;
			spawnObjectScript.PlaceObject (gameObject);
			placingObject = true;

			GetComponent<TileProperties> ().open = false;

			//StartCoroutine(Wait(clickedTile, Color.green, startcolor));
			//Fade(clickedTile, Color.green, startcolor);

			colorA = Color.green;
			isRising = true;

		} else if ((inside) && (GetComponent<TileProperties> ().open == false) && (placingObject != true))
		{

			//Renderer clickedTile = GetComponent<Renderer>();

			// If the tile is not free, turn it red when clicked
			//GetComponent<Renderer> ().material.color = Color.red;

			//StartCoroutine(Wait(clickedTile, Color.red, startcolor));
			//Fade(clickedTile, Color.red, startcolor);

			startcolor = GetComponent<Renderer> ().material.color;
			colorA = Color.red;
			isRising = true;

		}
	}

	#endif



	void OnMouseUp()
	{
		if (inside) 
		{
			//GetComponent<Renderer> ().material.color = Color.yellow;
		}
	}

	IEnumerator Wait(Renderer selectedTile, Color colorA, Color colorB) {
		

        yield return new WaitForSeconds(1);

		
		}

        //Fade(selectedTile, colorA, colorB);

		//GetComponent<Renderer> ().material.color = startcolor;

	void Fade (Renderer selectedTile, Color colorA, Color colorB)
	{

		




	}

	void OnMouseExit()
	{
		//inside = false;
		//GetComponent<Renderer> ().material.color = startcolor;
		//renderer.material.color = startcolor;
	}
}