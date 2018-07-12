using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelManager0 : MonoBehaviour {

	public GameObject gameOverUI;
	public GameObject gameWinUI;
	public int lives;
	public bool over;

	// Use this for initialization
	void Start () {
		lives=5;


	}

	void Update(){


	}



	public void lose(){
		if(over==false){
			gameOverUI.SetActive(true);
			over=true;
		}

	}
	public void restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void win(){
		if(over==false){
			gameWinUI.SetActive(true);
			over=true;
		}

	}



}
