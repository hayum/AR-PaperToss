using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelManager : MonoBehaviour {
	public GameObject gameOverUI;
	public GameObject gameWinUI;
	public int lives;
	public bool over;
	public Text lifeLeft;
	// Use this for initialization
	void Start () {
		lives=5;


	}

	void Update(){

		if(lives<0 && over==false){
			lose();
		}

		lifeLeft.text=lives.ToString();
	}

	public void life(){
		if(over==false){
		lives--;
		Debug.Log("life");
		}
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
