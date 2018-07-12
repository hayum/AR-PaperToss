using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	// Update is called once per frame

	void Update () {
		//-1 if moving left, 0 still, +1 if moving right
		float mouseHorizontal = Input.GetAxis("Mouse X");
		float mouseVertical = Input.GetAxis("Mouse Y");

		//rotate the object(Main 
		transform.Rotate(-mouseVertical,mouseHorizontal,0f);

		//un-roll the camera
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y,0f);

		// if you hold down LEFT MOUSE BUTTON, you move forward
		if(Input.GetMouseButton(0)==true){//"0"=left-click, "1"=right-click
			transform.Translate(0f, 0f,0.1f); //move forward based on my rotation
			//Cursor.lockState=CursorLockMode.Locked;
			//Cursor.visible=false;
		}

	}



}
