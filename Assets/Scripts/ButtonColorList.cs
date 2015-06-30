using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonColorList : MonoBehaviour {

	public Color[] buttonsColors = new Color[27] { 
		new Color(1f,0.5f,0.5f,1f), new Color (1f, 0f, 0f, 1f), new Color (0.5f, 0f, 0f, 1f),
		new Color (1f, 0.75f, 0.5f, 1f), new Color (1f, 0.5f, 0f, 1f), new Color (0.5f, 0.25f, 0f, 1f),
		new Color(1f,1f,0.5f,1f), new Color (1f, 1f, 0f, 1f), new Color (0.5f, 0.5f, 0f, 1f),
		new Color(0.5f,1f,0.5f,1f), new Color (0f, 1f, 0f, 1f), new Color (0f, 0.5f, 0f, 1f),
		new Color (0.5f, 1f, 1f, 1f), new Color(0f,1f,1f,1f), new Color (0f, 0.5f, 0.5f, 1f),
		new Color (0.5f, 0.5f, 1f, 1f), new Color(0f,0f,1f,1f), new Color (0f, 0f, 0.5f, 1f),
		new Color (0.75f, 0.5f, 1f, 1f), new Color (0.75f, 0f, 1f, 1f), new Color (0.5f, 0f, 0.5f, 1f),
		new Color (1f, 0.5f, 1f, 1f), new Color (1f, 0f, 1f, 1f),new Color (0.75f, 0f, 0.75f, 1f),
		new Color(1f,1f,1f,1f),	new Color(0.5f,0.5f,0.5f,1f), new Color(0f,0f,0f,1f)};

	// Use this for initialization
	void Start () {
		int colorCount = 0;
		foreach (Transform child in transform) {
			child.gameObject.GetComponent<Image>().color = buttonsColors[colorCount];
			colorCount++;
		}
	}
}
