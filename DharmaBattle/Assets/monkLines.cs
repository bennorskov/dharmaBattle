using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class monkLines : MonoBehaviour {
	public string[] lines;
	public Text targetText;
	public Image textBG;
	public float lineTimeout = 2f;
	// Use this for initialization
	void Start () {
		textBG = targetText.GetComponentInParent<Image>();
	}

	public void sayLine( int _lineNum) {
		textBG.enabled = true;
		_lineNum %= lines.Length;
		targetText.text = lines[_lineNum];
		StartCoroutine("fadeText");
	}
	IEnumerator fadeText() {
		yield return new WaitForSeconds(lineTimeout);
		textBG.enabled = false;
	}
}
