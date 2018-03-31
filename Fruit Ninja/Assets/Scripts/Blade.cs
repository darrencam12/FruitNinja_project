using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

		bool isCutting = false;
		Rigidbody2D rb;

		Camera cam;


	void Start() {
		//settig the camera to create the postion for the blade
		cam = Camera.main;
		// getting the rigidbody from the reference
		rb = GetComponent<Rigidbody2D>();

		
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
		// setting the rigidbody to mouse position
		rb.position = cam.ScreenToWorldPoint(Input.mousePosition);
	}

	void Startcutting()
	{
		// setting the cut value to true
		isCutting = true;
	}

	void Stopcutting()
	{
		// setting the cut value to false
		isCutting = false;
	}
}
