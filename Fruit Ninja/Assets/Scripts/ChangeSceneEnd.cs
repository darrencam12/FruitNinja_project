using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ChangeSceneEnd : MonoBehaviour {

	// Use this for initialization
	

	public void GotoEnd(int GotoEnd) {

		 SceneManager.LoadScene(GotoEnd);
	}
	
}
