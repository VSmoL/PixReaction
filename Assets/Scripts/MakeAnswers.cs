using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MakeAnswers : MonoBehaviour {

    public CheckAnswer chkAns;
    public ChangeEnemyColors cEnemyColors;
	public int answerCnt = 10;

    void Start() {
        int randomNumber;
        List<CorrectAnswerList> corAL = new List<CorrectAnswerList>();

		for (int i = 0; i < answerCnt; i++)
        {
            randomNumber = Random.Range(0, 2);
            corAL.Add(new CorrectAnswerList(randomNumber));
        }
        cEnemyColors.getAnswerList(corAL);
        cEnemyColors.changeColor(0);
        chkAns.getAnswerList(corAL);
        //chkAns.moveCurrentAnswerPos();
    }
}
