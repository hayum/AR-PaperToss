﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour {

	private float a,b,sum,left;
	private float hVelocity;
	// Use this for initialization
	void Start () {
		//1st part-1. Used to introduce coding in Unity( Start runs once)
		//Debug.Log("Hello World!");
		a=20f;
		b=0.2f;
	}

	// Update is called once per frame
	void Update () {
		//1st part-2. Used to introduce coding( Update runs once per frame)
		//		Debug.Log("Hello World!");




		//2nd part. Used to introduce math in coding and output
		//		sum=a+b;
		//		left=a-b;
		//		Debug.Log("sum="+sum);
		//		Debug.Log("left="+left);
		//
		//
		//		a++;
		//		b+=2;
		//		Debug.Log("a="+a+" b="+b);



		//3rd part. Used to inrtoduce function
		//		add();
		//		substract();
		//		Debug.Log("sum="+sum);
		//        Debug.Log("left="+left);


		//4th part. Used to connect math with real movement.
//		if(transform.position.x<20f){
//			transform.position=new Vector3(transform.position.x+0.2f, transform.position.y,transform.position.z);
//		}

		//5th part. Used to introduce keyboard input
		if(Input.GetMouseButton(0)==true){//"0"=left-click, "1"=right-click
			transform.Translate(0f, 0f,0.1f); 
		}

	}

	/*void add(){
		sum=a+b;


	}

	void substract(){
		left=a-b;
	}*/



}
