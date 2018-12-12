using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	public Text text;
	
	public int maxGuesslimit = 10;
	void Start () {
	    StartGame ();
	}
	void StartGame(){
		max = 1000;
		min = 1;
		NextGuess();
		
	}
	// Update is called once per frame

	public void GuessLower () {
		max = guess;
		NextGuess ();
	}
	public void GuessHigher () {
		min = guess;
		NextGuess ();
	}
	void NextGuess() {
		guess = Random.Range(min,max + 1);
		text.text = guess.ToString();
		maxGuesslimit = maxGuesslimit - 1;
		if(maxGuesslimit <= 0) {
			Application.LoadLevel("Win");
		}

	}
}
