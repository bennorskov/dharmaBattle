using UnityEngine;
using System.Collections;

public class handlePlayerInput : MonoBehaviour {

	monkLines ml;
	int currentLine = 0;
	// Use this for initialization
	void Start () {
		ml = GameObject.Find("Head Monk").GetComponent<monkLines>();
	}
	public void handleTextInput(string _input) {
		if( _input.Contains("vase") && ( _input.Contains("tip") || _input.Contains("knock") || _input.Contains("kick") ) {
			ml.sayLine(currentLine);
			currentLine++;
		}

	}
}
