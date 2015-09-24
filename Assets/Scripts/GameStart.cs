using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {
	
	public static bool GameOn;
	public static bool GameModeTimed;
	public static bool GameModeReaction;

	// Use this for initialization
	public void StartTimedGame (int btnGameModeId) {
		resetGame ();
		if (btnGameModeId == 0) {
			GameModeReaction = true;
			GameModeTimed = false;
		} else if (btnGameModeId == 1) {
			GameModeTimed = true;
			GameModeReaction = false;
		}
		Application.LoadLevel ("Game");


	}
	void resetGame(){
		CheckAnswer.answerNumber = 0;
		StartCountdown.yieldTime = 1;
		StartCountdown.pitchSpeed = 1;
		WriteAnswerLeft.answers = 0;
		GameOn = true;
	}
}
