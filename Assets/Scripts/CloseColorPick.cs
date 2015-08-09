using UnityEngine;
using System.Collections;

public class CloseColorPick : MonoBehaviour {

	public GameObject colorPickerLeft;
	public GameObject colorPickerLeft1;
	public GameObject colorPickerLeft2;
	public GameObject colorPickerRight;
	public GameObject colorPickerRight1;
	public GameObject colorPickerRight2;
	
	public GameObject closeColorPanelButton;

	public void closeColorPanel(){
		colorPickerLeft.SetActive (false);
		colorPickerLeft1.SetActive (false);
		colorPickerLeft2.SetActive (false);
		colorPickerRight.SetActive (false);
		colorPickerRight1.SetActive (false);
		colorPickerRight2.SetActive (false);
		closeColorPanelButton.SetActive (false);
	}
}
