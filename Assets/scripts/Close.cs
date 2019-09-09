using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Close : MonoBehaviour {

	// Use this for initialization
	public void closeapp() {

		Application.Quit ();
		Debug.Log ("itichA");
	}
	public void scan() {
		SceneManager.LoadScene ("2.animation");
	}
	public void scan1() {
		SceneManager.LoadScene ("mainscene");
	}

	public void back2(){
		SceneManager.LoadScene ("2.animation");
	}
}
