using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	

	public void GotoGame(int GotoGame) {

		 SceneManager.LoadScene(GotoGame);
	}
	
}
