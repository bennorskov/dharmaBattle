using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class monkLines : MonoBehaviour {
	public string[] lines;
	public GameObject textContainer;
	Text targetText;
	public float lineTimeout = 2f;
	// Use this for initialization
	void Start () {
		targetText = textContainer.GetComponentInChildren<Text>();
		textContainer.SetActive(false);
	}

	public void sayLine( int _lineNum) {
		textContainer.SetActive(true);
		_lineNum %= lines.Length;
		targetText.text = lines[_lineNum];
		StartCoroutine("fadeText");
	}

	public void sayLine( string _toSay) {
		textContainer.SetActive(true);
		targetText.text = _toSay;
		StartCoroutine("fadeText");
	}
	IEnumerator fadeText() {
		yield return new WaitForSeconds(lineTimeout);
		textContainer.SetActive(false);
	}
}
