using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

	public Button leftBtn;
	public Button rightBtn;

	public GameObject AnswerObject;
	public SpriteRenderer background;

	public void GameOverSaveDataTimed(){
		if(GameStart.GameOn){
			if(WriteTimeLeft.totalTime < PlayerPrefs.GetFloat("PlayerTopTimed",99999.99f)){
				GameStart.GameOn = false;
				PlayerPrefs.SetFloat("PlayerTopTimed", WriteTimeLeft.totalTime);
			}
		}
		GameStart.GameOn = false;
		StartCoroutine (restartGame ());
	}

	public void GameOverSaveDataReaction(){
		if(CheckAnswer.answerNumber > PlayerPrefs.GetInt ("PlayerTopReaction")){
			PlayerPrefs.SetInt("PlayerTopReaction", CheckAnswer.answerNumber);
		}
		GameStart.GameOn = false;
		StartCoroutine (restartGame ());
	}

	IEnumerator restartGame(){
		yield return new WaitForSeconds(3);
		Application.LoadLevel ("MainMenu");
	}

//	else if (GameStart.GameModeTimed){
//		if(!WriteTimeLeft.GameOver){
//			if(WriteTimeLeft.totalTime < PlayerPrefs.GetFloat("PlayerTopTimed",99999.99f)){
//				WriteTimeLeft.GameOver = true;
//				PlayerPrefs.SetFloat("PlayerTopTimed", WriteTimeLeft.totalTime);
//			}
//		}
//	}
}
