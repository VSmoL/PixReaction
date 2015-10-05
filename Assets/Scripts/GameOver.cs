using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	public GameObject AnswerObject;
	public SpriteRenderer background;
	public GameObject continueBtn;
	public GoogleAdVideo GAV;
	string difficultName;
	static int retryCount = 2;

	public void GameOverSaveDataTimed(){

		if(ChangeDifficult.difficultNumber == 1){
			difficultName = "easy";
		}
		else if(ChangeDifficult.difficultNumber == 2){
			difficultName = "medium";
		}
		else if(ChangeDifficult.difficultNumber == 3){
			difficultName = "hard";
		}

		if(GameStart.GameOn){
			if(WriteTimeLeft.totalTime < PlayerPrefs.GetFloat("PlayerTopTimed"+difficultName,99999.99f)){
				GameStart.GameOn = false;
				PlayerPrefs.SetFloat("PlayerTopTimed"+difficultName, WriteTimeLeft.totalTime);
			}
		}
		GameStart.GameOn = false;
		continueBtn.SetActive (true);
	}

	public void GameOverSaveDataReaction(){

		if(ChangeDifficult.difficultNumber == 1){
			difficultName = "easy";
		}
		else if(ChangeDifficult.difficultNumber == 2){
			difficultName = "medium";
		}
		else if(ChangeDifficult.difficultNumber == 3){
			difficultName = "hard";
		}

		if(CheckAnswer.answerNumber > PlayerPrefs.GetInt ("PlayerTopReaction"+difficultName)){

			PlayerPrefs.SetInt("PlayerTopReaction"+difficultName, CheckAnswer.answerNumber);
		}
		GameStart.GameOn = false;
		continueBtn.SetActive (true);
	}

	public void restartGame(){	
		retryCount += 1;
		Debug.Log(retryCount);
		if(retryCount % 3 == 0){
			GAV.ShowVideo ();
		}
		Application.LoadLevel ("MainMenu");
	}
}
