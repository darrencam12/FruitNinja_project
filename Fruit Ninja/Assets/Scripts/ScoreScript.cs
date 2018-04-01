using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {


	public static int scoreValue = 0;
	Text score;
	// Use this for initialization
	void Start () {
		// put the text in the score
		score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		// put the score in the text and add the value of scoreValue
		score.text = "" + scoreValue;
	}
}
