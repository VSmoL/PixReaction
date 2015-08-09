using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartSavedButtonColor : MonoBehaviour {

	public GameObject leftBtn;
	public GameObject leftBtn1;
	public GameObject leftBtn2;
	public GameObject rightBtn;
	public GameObject rightBtn1;
	public GameObject rightBtn2;

	// Use this for initialization
	void Start () {
		leftBtn.GetComponent<Image>().color = PlayerPrefsX.GetColor ("leftBtnColor", new Color(1f,0f,0f,1f));
		leftBtn.GetComponent<PlayerButtonId>().ColorId = PlayerPrefs.GetInt ("leftBtnId", 1);

		leftBtn1.GetComponent<Image>().color = PlayerPrefsX.GetColor ("leftBtnColor1", new Color(1f,1f,0f,1f));
		leftBtn1.GetComponent<PlayerButtonId>().ColorId = PlayerPrefs.GetInt ("leftBtnId1", 7);

		leftBtn2.GetComponent<Image>().color = PlayerPrefsX.GetColor ("leftBtnColor2", new Color(1f,0f,1f,1f));
		leftBtn2.GetComponent<PlayerButtonId>().ColorId = PlayerPrefs.GetInt ("leftBtnId2", 22);

		rightBtn.GetComponent<Image>().color = PlayerPrefsX.GetColor ("rightBtnColor", new Color(0f,1f,0f,1f));
		rightBtn.GetComponent<PlayerButtonId>().ColorId = PlayerPrefs.GetInt ("rightBtnId", 10);

		rightBtn1.GetComponent<Image>().color = PlayerPrefsX.GetColor ("rightBtnColor1", new Color(0f,1f,1f,1f));
		rightBtn1.GetComponent<PlayerButtonId>().ColorId = PlayerPrefs.GetInt ("rightBtnId1", 13);

		rightBtn2.GetComponent<Image>().color = PlayerPrefsX.GetColor ("rightBtnColor2", new Color(0f,0f,1f,1f));
		rightBtn2.GetComponent<PlayerButtonId>().ColorId = PlayerPrefs.GetInt ("rightBtnId2", 16);
	}
}
