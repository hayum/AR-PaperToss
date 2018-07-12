using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI2 : MonoBehaviour {

		public Transform farEnd;
		private Vector3 frometh;
		private Vector3 untoeth;
		private float secondsForOneLength = 5f;
	    levelManager manager;
		void Start()
		{
			frometh = transform.position;
			untoeth = farEnd.position;
		    manager=GameObject.Find("GameControl").GetComponent<levelManager>();
		}

		void Update()
		{
			transform.position = Vector3.Lerp(frometh, untoeth,
				Mathf.SmoothStep(0f,1f,
					Mathf.PingPong(Time.time/secondsForOneLength, 1f)
				) );
		    
		}
	void OnTriggerEnter(Collider other){

		if(other.CompareTag("bullet")){
			Debug.Log("Collide");
			manager.win();

		}
	}

}
