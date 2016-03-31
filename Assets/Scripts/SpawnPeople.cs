using UnityEngine;
using System.Collections;

public class SpawnPeople : MonoBehaviour {

	public GameObject person;
	public GameObject personclone;

	// Use this for initialization
	void Start ()
	{
		Invoke("RandomLogic", 1);
	}


	void RandomLogic() {
		float randomTime = Random.Range (2, 5);

		Invoke("SpawnPerson", randomTime);
	}

	void SpawnPerson()
	{
		GameObject personclone = Instantiate(person, transform.position, transform.rotation) as GameObject;

		if (this.tag == "EastSpawn")
		{
			personclone.tag = "EastSpawnPerson";
		}
		else if (this.tag == "WestSpawn")
		{
			personclone.tag = "WestSpawnPerson";
		}

		Invoke ("RandomLogic", 1);
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		
	}



}
