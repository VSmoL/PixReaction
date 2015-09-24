using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CheckAnswer : MonoBehaviour {

    private List<CorrectAnswerList> corAL = new List<CorrectAnswerList>();
	public MakeAnswers MA;
	
    public ChangeEnemyColors cEnemyColors;
	public FlashBackground flashBg;
	public WriteTimeLeft WTL;
	public WriteAnswerLeft WAL;
	public StartCountdown SCD;
	public GameOver GO;
	
    public static int answerNumber = 0;

    public void getAnswerList(List<CorrectAnswerList> sentList)
    {
        corAL = sentList;
    }

    public void checkPlayerAnswer(int playerAnswer)
    {
		if (GameStart.GameModeReaction) {
			if(playerAnswer == MakeAnswers.IntAnswerId){
				answerNumber += 1;
				StartCoroutine(SCD.reactionTimeCountdown());
				WTL.answerRight();
				WAL.writeAns ();
				flashBg.rightAnswer ();
			} 
			else{
				GameStart.GameOn = false;
				flashBg.wrongAnswer ();
				GO.GameOverSaveDataReaction();
				SCD.playLoseSound();
			}
		} else if (GameStart.GameModeTimed) {
			if (playerAnswer == corAL [answerNumber].answerId) {
				cEnemyColors.changeColor (answerNumber + 1);
				WAL.writeAnsLeft ();
				answerNumber += 1;
				if (answerNumber >= corAL.Count) {
					GO.GameOverSaveDataTimed();
					flashBg.lastRightAnswer();
					SCD.playWinSound();
					WriteTimeLeft.GameOver = true;
				}
				else{
					flashBg.rightAnswer ();
				}
			} else {
				WriteTimeLeft.GameOver = true;
				GameStart.GameOn = false;
				GO.GameOverSaveDataTimed();
				flashBg.wrongAnswer ();
				SCD.playLoseSound();
			}
		}
    }
}







