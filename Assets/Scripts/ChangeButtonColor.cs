using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeButtonColor : MonoBehaviour {

	public GameObject leftButton;
	public GameObject leftButton1;
	public GameObject leftButton2;
	public GameObject rightButton;
	public GameObject rightButton1;
	public GameObject rightButton2;

	void Start(){
		
	}

	#region Left Color Change
	public void ChangeColorLeft(Transform pressedBtn){

		checkDuplicateColors (pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber, leftButton);

		leftButton.GetComponent<Image>().color = pressedBtn.gameObject.GetComponent<Image> ().color;
		leftButton.GetComponent<PlayerButtonId> ().ColorId = pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber;

		PlayerPrefsX.SetColor ("leftBtnColor", pressedBtn.gameObject.GetComponent<Image> ().color);
		PlayerPrefs.SetInt ("leftBtnId", pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber);
	}
	public void ChangeColorLeft1(Transform pressedBtn){

		checkDuplicateColors (pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber, leftButton1);

		leftButton1.GetComponent<Image>().color = pressedBtn.gameObject.GetComponent<Image> ().color;
		leftButton1.GetComponent<PlayerButtonId> ().ColorId = pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber;

		PlayerPrefsX.SetColor ("leftBtnColor1", pressedBtn.gameObject.GetComponent<Image> ().color);
		PlayerPrefs.SetInt ("leftBtnId1", pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber);
	}
	public void ChangeColorLeft2(Transform pressedBtn){
		
		checkDuplicateColors (pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber, leftButton2);

		leftButton2.GetComponent<Image>().color = pressedBtn.gameObject.GetComponent<Image> ().color;
		leftButton2.GetComponent<PlayerButtonId> ().ColorId = pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber;

		PlayerPrefsX.SetColor ("leftBtnColor2", pressedBtn.gameObject.GetComponent<Image> ().color);
		PlayerPrefs.SetInt ("leftBtnId2", pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber);
	}
	#endregion

	#region Right Color Change
	public void ChangeColorRight(Transform pressedBtn){
		
		checkDuplicateColors (pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber, rightButton);

		rightButton.GetComponent<Image>().color = pressedBtn.gameObject.GetComponent<Image> ().color;
		rightButton.GetComponent<PlayerButtonId> ().ColorId = pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber;

		PlayerPrefsX.SetColor ("rightBtnColor", pressedBtn.gameObject.GetComponent<Image> ().color);
		PlayerPrefs.SetInt ("rightBtnId", pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber);
	}
	public void ChangeColorRight1(Transform pressedBtn){
		
		checkDuplicateColors (pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber, rightButton1);

		rightButton1.GetComponent<Image>().color = pressedBtn.gameObject.GetComponent<Image> ().color;
		rightButton1.GetComponent<PlayerButtonId> ().ColorId = pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber;

		PlayerPrefsX.SetColor ("rightBtnColor1", pressedBtn.gameObject.GetComponent<Image> ().color);
		PlayerPrefs.SetInt ("rightBtnId1", pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber);
	}
	public void ChangeColorRight2(Transform pressedBtn){
		
		checkDuplicateColors (pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber, rightButton2);

		rightButton2.GetComponent<Image>().color = pressedBtn.gameObject.GetComponent<Image> ().color;
		rightButton2.GetComponent<PlayerButtonId> ().ColorId = pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber;

		PlayerPrefsX.SetColor ("rightBtnColor2", pressedBtn.gameObject.GetComponent<Image> ().color);
		PlayerPrefs.SetInt ("rightBtnId2", pressedBtn.gameObject.GetComponent<ColorId> ().ColorNumber);
	}
	#endregion

	void checkDuplicateColors(int verrattavaId, GameObject buttonColorChange){
		if (leftButton.GetComponent<PlayerButtonId> ().ColorId == verrattavaId) {
			leftButton.GetComponent<Image>().color = buttonColorChange.GetComponent<Image>().color;
			leftButton.GetComponent<PlayerButtonId> ().ColorId = buttonColorChange.GetComponent<PlayerButtonId> ().ColorId;
			
			PlayerPrefsX.SetColor ("leftBtnColor", buttonColorChange.GetComponent<Image>().color);
			PlayerPrefs.SetInt ("leftBtnId", buttonColorChange.GetComponent<PlayerButtonId> ().ColorId);
		}
		else if(leftButton1.GetComponent<PlayerButtonId> ().ColorId == verrattavaId) {
			leftButton1.GetComponent<Image>().color = buttonColorChange.GetComponent<Image>().color;
			leftButton1.GetComponent<PlayerButtonId> ().ColorId = buttonColorChange.GetComponent<PlayerButtonId> ().ColorId;
			
			PlayerPrefsX.SetColor ("leftBtnColor1", buttonColorChange.GetComponent<Image>().color);
			PlayerPrefs.SetInt ("leftBtnId1", buttonColorChange.GetComponent<PlayerButtonId> ().ColorId);
		}
		else if(leftButton2.GetComponent<PlayerButtonId> ().ColorId == verrattavaId) {
			leftButton2.GetComponent<Image>().color = buttonColorChange.GetComponent<Image>().color;
			leftButton2.GetComponent<PlayerButtonId> ().ColorId = buttonColorChange.GetComponent<PlayerButtonId> ().ColorId;
			
			PlayerPrefsX.SetColor ("leftBtnColor2", buttonColorChange.GetComponent<Image>().color);
			PlayerPrefs.SetInt ("leftBtnId2", buttonColorChange.GetComponent<PlayerButtonId> ().ColorId);
		}
		else if(rightButton.GetComponent<PlayerButtonId> ().ColorId == verrattavaId) {
			rightButton.GetComponent<Image>().color = buttonColorChange.GetComponent<Image>().color;
			rightButton.GetComponent<PlayerButtonId> ().ColorId = buttonColorChange.GetComponent<PlayerButtonId> ().ColorId;

			PlayerPrefsX.SetColor ("rightBtnColor", buttonColorChange.GetComponent<Image>().color);
			PlayerPrefs.SetInt ("rightBtnId", buttonColorChange.GetComponent<PlayerButtonId> ().ColorId);
		}
		else if(rightButton1.GetComponent<PlayerButtonId> ().ColorId == verrattavaId) {
			rightButton1.GetComponent<Image>().color = buttonColorChange.GetComponent<Image>().color;
			rightButton1.GetComponent<PlayerButtonId> ().ColorId = buttonColorChange.GetComponent<PlayerButtonId> ().ColorId;
			
			PlayerPrefsX.SetColor ("rightBtnColor1", buttonColorChange.GetComponent<Image>().color);
			PlayerPrefs.SetInt ("rightBtnId1", buttonColorChange.GetComponent<PlayerButtonId> ().ColorId);
		}
		else if(rightButton2.GetComponent<PlayerButtonId> ().ColorId == verrattavaId) {
			rightButton2.GetComponent<Image>().color = buttonColorChange.GetComponent<Image>().color;
			rightButton2.GetComponent<PlayerButtonId> ().ColorId = buttonColorChange.GetComponent<PlayerButtonId> ().ColorId;
			
			PlayerPrefsX.SetColor ("rightBtnColor2", buttonColorChange.GetComponent<Image>().color);
			PlayerPrefs.SetInt ("rightBtnId2", buttonColorChange.GetComponent<PlayerButtonId> ().ColorId);
		}
	}

}
