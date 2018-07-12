using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AI : MonoBehaviour {
	Transform target;
	float maxLookDis;
	float maxAttackDis;
	float minDistFromPlayer;
	float rotationDamping;
	float interval;
	float shotTime;
	public GameObject particleEffect2;
	float positionY;
	//public int length;
	//public GameObject projectile;
	Animator ani;
	float timeLookedAt = 0f;
	levelManager manager;
	shooting charc;
	// Use this for initialization
	void Start () {
		target=GameObject.FindWithTag("MainCamera").transform;
		charc = GameObject.FindWithTag("MainCamera").GetComponent<shooting> ();
		manager=GameObject.Find("GameControl").GetComponent<levelManager>();
		maxLookDis=25f;
		maxAttackDis=25f;
		minDistFromPlayer=0f;
		rotationDamping=2f;
		interval=2f;
		shotTime=0f;
		positionY=transform.position.y;
		//ani = gameObject.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		float dist=Vector3.Distance(target.position,transform.position);
		if(dist<=maxLookDis){
			LookAtTarget();
			if(dist<=maxAttackDis && dist>=minDistFromPlayer){
				Chase();
				if(Time.time - shotTime > interval){
					//Shoot();
				}
			}
			//else{ani.SetFloat("Forward",0f);}
		}

		//VR
//		if(Vector3.Distance(Camera.main.transform.position,transform.position)<5f){
//			GetComponent<Collider>().enabled=true;
//		}
//		else{
//			GetComponent<Collider>().enabled=false;
//		}
//
//
//		//1.caculate the raycast origin and direction
//		Ray ray =new Ray(Camera.main.transform.position, Camera.main.transform.forward);
//
//		//2.setup RaycastHit variable,reserve memory for it
//		RaycastHit beHit=new RaycastHit();
//
//		//3.test our Raycast
//		if (Physics.Raycast (ray, out beHit, 20f)) {
//			//4.did they raycast hit this object
//			if (beHit.collider == GetComponent<Collider> ()) {
//				Debug.Log ("raycast hit on" + gameObject.name);
//				timeLookedAt += Time.deltaTime;//deltatime is how long the frame is  30fps them deltaTime is 1/30
//				if (timeLookedAt >= 1f) {
//					charc.fire ();
//				}
//			} 
//			else {
//				timeLookedAt = 0f;   
//			}
//		} 
//		else {
//			timeLookedAt = 0f;
//		}



	}

	void Chase(){
		transform.position = Vector3.MoveTowards(transform.position, target.position, 6*Time.deltaTime);
		//ani.SetFloat("Forward",0.5f);
		Vector3 temp=transform.position;
		temp.y=positionY;
		transform.position=temp;
	}

	void LookAtTarget(){
		Vector3 dir= target.position-transform.position;
		dir.y=0f;
		var rotation = Quaternion.LookRotation(dir);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
	}

//	void Shoot(){
//		shotTime=Time.time;
//		GameObject projectileIns=Instantiate(projectile, transform.position+Vector3.up, Quaternion.LookRotation(target.position - transform.position));
//		projectileIns.GetComponent<Rigidbody>().velocity = transform.forward * 15;
//		Destroy(projectileIns,3f);
//	}

	void OnTriggerEnter(Collider other){
		
		if(other.CompareTag("bullet")){
			//Destroy(gameObject);
			Destroy(transform.root.gameObject);
			Instantiate(particleEffect2, transform.position, Quaternion.identity);
			//Destroy(gameObject.parent)
		}
		if(other.CompareTag("MainCamera")){

			manager.lose();

		}
	}

}
