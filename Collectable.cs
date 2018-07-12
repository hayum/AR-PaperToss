using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	levelManager result;
	// Use this for initialization
	void Start () {
		result=GameObject.Find("GameControl").GetComponent<levelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		if(other.CompareTag("MainCamera")){
			Destroy(gameObject);
			result.win();

		}
	}
}
