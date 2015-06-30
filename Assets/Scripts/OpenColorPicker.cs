using UnityEngine;
using System.Collections;

public class OpenColorPicker : MonoBehaviour {

	public GameObject colorPickerLeft;
	public GameObject colorPickerRight;
	public GameObject colorPickerArrowLeft;
	public GameObject colorPickerArrowRight;

	// Use this for initialization
	public void OpenColorPickerList (int menuButton) {
		if (!GameStart.GameOn) {
			if (colorPickerLeft.activeSelf || colorPickerRight.activeSelf) {
				if (menuButton == 0) {
					if(colorPickerLeft.activeSelf){
						colorPickerLeft.SetActive (false);
						colorPickerArrowLeft.SetActive (true);
						colorPickerArrowRight.SetActive(true);
					}
					else if(colorPickerRight.activeSelf){
						colorPickerLeft.SetActive (true);
						colorPickerRight.SetActive(false);
						//					colorPickerArrowLeft.SetActive (true);
						//					colorPickerArrowRight.SetActive(true);
					}
				}
				else if(menuButton == 1){
					if(colorPickerLeft.activeSelf){
						colorPickerLeft.SetActive (false);
						colorPickerRight.SetActive(true);
						//					colorPickerArrowLeft.SetActive (true);
						//					colorPickerArrowRight.SetActive(true);
					}
					else if(colorPickerRight.activeSelf){
						colorPickerRight.SetActive (false);
						colorPickerArrowLeft.SetActive (true);
						colorPickerArrowRight.SetActive(true);
					}
				}
			} else {
				if (menuButton == 0) {
					colorPickerLeft.SetActive (true);
					colorPickerArrowLeft.SetActive (false);
					colorPickerArrowRight.SetActive(false);
				}
				else if(menuButton == 1){
					colorPickerRight.SetActive(true);
					colorPickerArrowLeft.SetActive (false);
					colorPickerArrowRight.SetActive(false);
				}
			}
		}
	}
}
