using UnityEngine;
using System.Collections;

public class ChangeDifficult : MonoBehaviour {

	public WriteDifficult WD;
	public WritePersonalBestReaction WPBR;
	public WritePersonalBestTimed WPBT;
	public static int difficultNumber = 1;

	public GameObject leftButton;
	public GameObject leftButton1;
	public GameObject leftButton2;
	public GameObject rightButton;
	public GameObject rightButton1;
	public GameObject rightButton2;

	void Start(){

		difficultNumber = PlayerPrefs.GetInt ("DifficultInt", 1);
		Debug.Log ("vaikeus" + difficultNumber);

		if (difficultNumber == 1) {
			WD.DifficultWriteText (difficultNumber);
			WPBR.reactionTopRefresh("easy");
			WPBT.timedTopRefresh("easy");

			leftButton.SetActive(true);
			leftButton1.SetActive(false);
			leftButton2.SetActive(false);
			rightButton.SetActive(true);
			rightButton1.SetActive(false);
			rightButton2.SetActive(false);
		} 
		else if (difficultNumber == 2) {
			WD.DifficultWriteText (difficultNumber);
			WPBR.reactionTopRefresh("medium");
			WPBT.timedTopRefresh("medium");

			leftButton.SetActive(true);
			leftButton1.SetActive(true);
			leftButton2.SetActive(false);
			rightButton.SetActive(true);
			rightButton1.SetActive(true);
			rightButton2.SetActive(false);
		} 
		else if (difficultNumber == 3) {
			WD.DifficultWriteText (difficultNumber);
			WPBR.reactionTopRefresh("hard");
			WPBT.timedTopRefresh("hard");

			leftButton.SetActive(true);
			leftButton1.SetActive(true);
			leftButton2.SetActive(true);
			rightButton.SetActive(true);
			rightButton1.SetActive(true);
			rightButton2.SetActive(true);
		}
	}

	public void difficultChangeIncrease(){
		difficultNumber += 1;
		if (difficultNumber == 1) {
			WD.DifficultWriteText (difficultNumber);
			WPBR.reactionTopRefresh("easy");
			WPBT.timedTopRefresh("easy");

			leftButton.SetActive(true);
			leftButton1.SetActive(false);
			leftButton2.SetActive(false);
			rightButton.SetActive(true);
			rightButton1.SetActive(false);
			rightButton2.SetActive(false);

			PlayerPrefs.SetInt("DifficultInt", difficultNumber);
		} 
		else if (difficultNumber == 2) {
			WD.DifficultWriteText (difficultNumber);
			WPBR.reactionTopRefresh("medium");
			WPBT.timedTopRefresh("medium");

			leftButton.SetActive(true);
			leftButton1.SetActive(true);
			leftButton2.SetActive(false);
			rightButton.SetActive(true);
			rightButton1.SetActive(true);
			rightButton2.SetActive(false);
		
			PlayerPrefs.SetInt("DifficultInt", difficultNumber);
		} 
		else if (difficultNumber == 3) {
			WD.DifficultWriteText (difficultNumber);
			WPBR.reactionTopRefresh("hard");
			WPBT.timedTopRefresh("hard");

			leftButton.SetActive(true);
			leftButton1.SetActive(true);
			leftButton2.SetActive(true);
			rightButton.SetActive(true);
			rightButton1.SetActive(true);
			rightButton2.SetActive(true);

			PlayerPrefs.SetInt("DifficultInt", difficultNumber);
		}
		else if (difficultNumber >= 4) {
			difficultNumber = 0;
			difficultChangeIncrease();
		}
	}
	public void difficultChangeDecrease(){
		difficultNumber -= 1;
		if (difficultNumber == 1) {
			WD.DifficultWriteText (difficultNumber);
			WPBR.reactionTopRefresh("easy");
			WPBT.timedTopRefresh("easy");

			leftButton.SetActive(true);
			leftButton1.SetActive(false);
			leftButton2.SetActive(false);
			rightButton.SetActive(true);
			rightButton1.SetActive(false);
			rightButton2.SetActive(false);

			PlayerPrefs.SetInt("DifficultInt", difficultNumber);
		}
		else if (difficultNumber == 2) {
			WD.DifficultWriteText (difficultNumber);
			WPBR.reactionTopRefresh("medium");
			WPBT.timedTopRefresh("medium");

			leftButton.SetActive(true);
			leftButton1.SetActive(true);
			leftButton2.SetActive(false);
			rightButton.SetActive(true);
			rightButton1.SetActive(true);
			rightButton2.SetActive(false);

			PlayerPrefs.SetInt("DifficultInt", difficultNumber);
		}
		else if (difficultNumber == 3) {
			WD.DifficultWriteText (difficultNumber);
			WPBR.reactionTopRefresh("hard");
			WPBT.timedTopRefresh("hard");

			leftButton.SetActive(true);
			leftButton1.SetActive(true);
			leftButton2.SetActive(true);
			rightButton.SetActive(true);
			rightButton1.SetActive(true);
			rightButton2.SetActive(true);

			PlayerPrefs.SetInt("DifficultInt", difficultNumber);
		}
		else if (difficultNumber <= 0) {
			difficultNumber = 4;
			difficultChangeDecrease();
		}
	}
}
