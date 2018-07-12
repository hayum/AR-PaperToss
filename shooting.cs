using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
	
	public GameObject projectilePrefab;
	GameObject projectileInstance;
	public float posOffset=0f;
	float interval,oldTime;
	levelManager manager;
	// Use this for initialization
	void Start () {
		interval=0.5f;
		manager=GameObject.Find("GameControl").GetComponent<levelManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
//			if(Input.GetKeyDown(KeyCode.V)){
		if(Input.GetMouseButton(0)==true && Time.time>oldTime+interval && manager.lives>=0 && manager.over==false){
				Debug.Log("V");
			    fire();
			    oldTime=Time.time;
				manager.life();
			}

	}

	public void fire(){
		Vector3 projPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+posOffset, gameObject.transform.position.z);
		projectileInstance = Instantiate (projectilePrefab, projPosition, gameObject.transform.rotation) as GameObject;
		//GameObject boneClone = Instantiate(bone, bonePos.position, bonePos.rotation,transform);
		projectileInstance.GetComponent<Rigidbody>().velocity = transform.forward * 20f;//20
		Destroy(projectileInstance,3f);//1
	}
}
