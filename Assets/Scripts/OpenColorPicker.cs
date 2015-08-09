using UnityEngine;
using System.Collections;

public class OpenColorPicker : MonoBehaviour {

	public GameObject colorPickerLeft;
	public GameObject colorPickerLeft1;
	public GameObject colorPickerLeft2;
	public GameObject colorPickerRight;
	public GameObject colorPickerRight1;
	public GameObject colorPickerRight2;

	public GameObject closeColorPanelButton;

	// Use this for initialization
	public void OpenColorPickerList (int menuButton) {
		if (!GameStart.GameOn) {
			if (colorPickerLeft.activeSelf || colorPickerLeft1.activeSelf || colorPickerLeft2.activeSelf || colorPickerRight.activeSelf || colorPickerRight1.activeSelf || colorPickerRight2.activeSelf) {
				if (menuButton == 0) {
					if(colorPickerLeft2.activeSelf){
						colorPickerLeft2.SetActive(false);
					}
					else{
						colorPickerLeft2.SetActive(true);
					}

					colorPickerLeft.SetActive(false);
					colorPickerLeft1.SetActive (false);
					colorPickerRight.SetActive(false);
					colorPickerRight1.SetActive(false);
					colorPickerRight2.SetActive(false);
				}
				else if(menuButton == 1){
					if(colorPickerLeft1.activeSelf){
						colorPickerLeft1.SetActive(false);
					}
					else{
						colorPickerLeft1.SetActive(true);
					}

					colorPickerLeft.SetActive(false);
					colorPickerLeft2.SetActive (false);
					colorPickerRight.SetActive(false);
					colorPickerRight1.SetActive(false);
					colorPickerRight2.SetActive(false);
				}
				else if(menuButton == 2){
					if(colorPickerLeft.activeSelf){
						colorPickerLeft.SetActive(false);
					}
					else{
						colorPickerLeft.SetActive(true);
					}

					colorPickerLeft1.SetActive(false);
					colorPickerLeft2.SetActive (false);
					colorPickerRight.SetActive(false);
					colorPickerRight1.SetActive(false);
					colorPickerRight2.SetActive(false);
				}
				else if(menuButton == 3){
					if(colorPickerRight2.activeSelf){
						colorPickerRight2.SetActive(false);
					}
					else{
						colorPickerRight2.SetActive(true);
					}

					colorPickerLeft.SetActive(false);
					colorPickerLeft1.SetActive (false);
					colorPickerLeft2.SetActive(false);
					colorPickerRight.SetActive(false);
					colorPickerRight1.SetActive(false);
				}
				else if(menuButton == 4){
					if(colorPickerRight1.activeSelf){
						colorPickerRight1.SetActive(false);
					}
					else{
						colorPickerRight1.SetActive(true);
					}
					colorPickerLeft.SetActive(false);
					colorPickerLeft1.SetActive (false);
					colorPickerLeft2.SetActive(false);
					colorPickerRight.SetActive(false);
					colorPickerRight2.SetActive(false);
				}
				else if(menuButton == 5){
					if(colorPickerRight.activeSelf){
						colorPickerRight.SetActive(false);
					}
					else{
						colorPickerRight.SetActive(true);
					}

					colorPickerLeft.SetActive(false);
					colorPickerLeft1.SetActive (false);
					colorPickerLeft2.SetActive(false);
					colorPickerRight1.SetActive(false);
					colorPickerRight2.SetActive(false);
				}
			} else {
				if (menuButton == 0) {
					colorPickerLeft2.SetActive (true);
				}
				else if(menuButton == 1){
					colorPickerLeft1.SetActive(true);
				}
				else if(menuButton == 2){
					colorPickerLeft.SetActive(true);
				}
				else if(menuButton == 3){
					colorPickerRight2.SetActive(true);
				}
				else if(menuButton == 4){
					colorPickerRight1.SetActive(true);
				}
				else if(menuButton == 5){
					colorPickerRight.SetActive(true);
				}
			}
		}
		closeColorPanelButton.SetActive (true);
	}
}
