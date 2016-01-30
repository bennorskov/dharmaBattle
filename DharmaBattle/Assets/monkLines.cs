using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class monkLines : MonoBehaviour {
	public string[] lines;
	public Text targetText;
	public GameObject textBG;
	public float lineTimeout = 2f;
	// Use this for initialization
	void Start () {
		textBG = targetText.transform.parent.gameObject;
	}

	public void sayLine( int _lineNum) {
		textBG.SetActive(true);
		_lineNum %= lines.Length;
		targetText.text = lines[_lineNum];
		StartCoroutine("fadeText");
	}
	IEnumerator fadeText() {
		yield return new WaitForSeconds(lineTimeout);
		textBG.SetActive(false);
	}
}
