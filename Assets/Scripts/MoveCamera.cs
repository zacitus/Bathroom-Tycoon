using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public float camera_speed;
	public float speed = 0.00000000000000000000000000000000000001F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate (Vector3.left * camera_speed);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate (Vector3.right * camera_speed);
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate (Vector3.up * camera_speed);
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate (Vector3.down * camera_speed);
		}

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
			// Get movement of the finger since last frame
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

			// Move object across XY plane
			transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
		}

	}
}
