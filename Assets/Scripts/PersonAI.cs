using UnityEngine;
using System.Collections;

public class PersonAI : MonoBehaviour {

	public GameObject[] endPoints;

	public float speed;

	private bool decision = false;
	private bool needToRelieve = false;

	void Start ()
	{
		gameObject.GetComponent<NavMeshAgent> ().speed = Random.Range(2,6);
		NewDestination();
	}

	// Use this for initialization
	void Awake () 
	{

	}

	void NewDestination ()
	{
		if (tag == "WestSpawnPerson") 
		{
			endPoints = GameObject.FindGameObjectsWithTag ("EastSpawn");
		} 
		else if (tag == "EastSpawnPerson")
		{
			endPoints = GameObject.FindGameObjectsWithTag ("WestSpawn");
		}
		NavMeshAgent agent = GetComponent<NavMeshAgent>();

		int x = endPoints.Length;
		Debug.Log ("X is " + x);

		int y = Random.Range (0, x);
		Debug.Log ("Y is " + y);

		agent.destination = endPoints [y].GetComponent<Transform>().position;
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{

		if (other.tag == "Decision")
		{
			decision = true;
		}

		if (decision)
		{
			if (other.tag == "WestSpawn" || other.tag == "EastSpawn")
			{
				Destroy (gameObject);
			}
		}
	}
}
