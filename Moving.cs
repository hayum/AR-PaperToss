using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	public float hspeed;
	//public Transform target;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		gameObject.transform.position += gameObject.transform.forward * hspeed * Time.deltaTime;
		//transform.position = Vector3.MoveTowards(transform.position, target.position, 2*Time.deltaTime);
		Destroy(this.gameObject, 2f);
	}

}
