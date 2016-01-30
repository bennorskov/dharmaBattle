using UnityEngine;
using System.Collections;

public class handlePlayerInput : MonoBehaviour {

	monkLines headML, yourML;
	int currentLine = 0;
	// Use this for initialization
	void Start () {
		headML = GameObject.Find("Head Monk").GetComponent<monkLines>();
		yourML = GameObject.Find("You Monk").GetComponent<monkLines>();
	}
	public void handleTextInput(string _input) {
		if( _input.Contains("vase") && ( _input.Contains("tip") || _input.Contains("knock") || _input.Contains("kick") ) ) {
			headML.sayLine(currentLine);
			currentLine++;
		} else {
			yourML.sayLine(_input);
		}

	}
}
