using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

		public GameObject BladeTrailprefab;
		
		public float minCuttingVelocity = .001f;

		bool isCutting = false;

		Vector2 previousPosition;

		GameObject currentBladetrail;

		Rigidbody2D rb;

		Camera cam;

		CircleCollider2D circleCollider;

	void Start() {
		//settig the camera to create the postion for the blade
		cam = Camera.main;
		// getting the rigidbody from the reference
		rb = GetComponent<Rigidbody2D>();
		//getting the circlecollider2d for the balde dittection of fruit
		circleCollider = GetComponent<CircleCollider2D>();

		
	}

	// Update is called once per frame
	void Update () {
		// checking if the mouse click is pressed 0 = left mouse button
		if(Input.GetMouseButtonDown(0))
		{
			Startcutting();
		}
		// checking if the mouse click is released 0 = left mouse button
		else if (Input.GetMouseButtonUp(0))
		{
			Stopcutting();
		}
		
		// if it is cutting keep cutting
		if (isCutting)
		{
			UpdateCut();
		}
	}

	void UpdateCut()
	{
		//getting a vector between the new position being the mouse and out previous position "when last clicked" with then we are getting the speed of the mouse that being Velocity 
		Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);

		// setting the rigidbody to mouse position
		rb.position = newPosition;

		//fixes the velocity without the interfireance of the framerate
		float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;

		if(velocity > minCuttingVelocity)
		{
			circleCollider.enabled = true;
		}else{
			circleCollider.enabled = false;
		}
		previousPosition = newPosition;
	}

	void Startcutting()
	{
		// setting the cut value to true
		isCutting = true;
		
		// parenting the prefab for the blade trail
		currentBladetrail = Instantiate(BladeTrailprefab, transform);
		circleCollider.enabled = false;
	}

	void Stopcutting()
	{
		// setting the cut value to false
		isCutting = false;

		// de parrenting the prefab for the balde trail
		currentBladetrail.transform.SetParent(null);
		//destroying the blade trail after 1 second
		Destroy(currentBladetrail,1f);
		circleCollider.enabled = false;
	}
}
