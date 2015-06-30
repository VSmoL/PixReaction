using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeButtonColor : MonoBehaviour {

	public Image leftButton;
	public Image rightButton;

	void Start(){
		
	}

	public void ChangeColorLeft(Transform pressedBtn){
		leftButton.color = pressedBtn.gameObject.GetComponent<Image> ().color;
		PlayerPrefsX.SetColor ("leftBtnColor", pressedBtn.gameObject.GetComponent<Image> ().color);
	}

	public void ChangeColorRight(Transform pressedBtn){
		rightButton.color = pressedBtn.gameObject.GetComponent<Image> ().color;
		PlayerPrefsX.SetColor ("rightBtnColor", pressedBtn.gameObject.GetComponent<Image> ().color);
	}
}
