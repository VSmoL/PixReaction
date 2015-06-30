using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartSavedButtonColor : MonoBehaviour {

	public Image leftBtn;
	public Image rightBtn;

	// Use this for initialization
	void Start () {
		leftBtn.color = PlayerPrefsX.GetColor ("leftBtnColor", new Color(1f,0f,0f,1f));
		rightBtn.color = PlayerPrefsX.GetColor ("rightBtnColor", new Color(0f,1f,0f,1f));
	}
}
