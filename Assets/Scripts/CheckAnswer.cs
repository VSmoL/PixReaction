using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CheckAnswer : MonoBehaviour {

    private List<CorrectAnswerList> corAL = new List<CorrectAnswerList>();
	
    public ChangeEnemyColors cEnemyColors;
	public FlashBackground flashBg;
	public WriteAnswerLeft WTL;
	
    private int answerNumber = 0;

    public void getAnswerList(List<CorrectAnswerList> sentList)
    {
        corAL = sentList;
    }

    public void checkPlayerAnswer(int playerAnswer)
    {
        if (playerAnswer == corAL[answerNumber].answerId)
        {
            cEnemyColors.changeColor(answerNumber + 1);
			flashBg.rightAnswer();
			WTL.writeAnsLeft();
            print("oikein");
        }
        else
        {
			WriteTimeLeft.GameOver = true;
			flashBg.wrongAnswer();
            print("väärin");
        }
		answerNumber += 1;
    }
}
