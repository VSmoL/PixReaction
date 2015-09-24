using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MakeAnswers : MonoBehaviour {

    public CheckAnswer chkAns;
    public ChangeEnemyColors cEnemyColors;
	public Transform btnList;
	public int answerCnt = 10;
	public static int IntAnswerId;
	public int buttonCnt;

	public void getButtonCntTimed(){
		buttonCnt = 0;
		foreach (Transform btnChild in btnList) {
			foreach(Transform btnChildChild in btnChild){
				if(btnChildChild.gameObject.tag == "Button" && btnChildChild.gameObject.activeSelf){
					buttonCnt += 1;
				}
			}
		}
		MakeAnswerList ();
	}

	public void getButtonCntReaction(){
		buttonCnt = 0;
		foreach (Transform btnChild in btnList) {
			foreach(Transform btnChildChild in btnChild){
				if(btnChildChild.gameObject.tag == "Button" && btnChildChild.gameObject.activeSelf){
					buttonCnt += 1;
				}
			}
		}
		MakeReactionAnswer ();
	}

    public void MakeAnswerList() {
        int randomNumber;
        List<CorrectAnswerList> corAL = new List<CorrectAnswerList>();

		for (int i = 0; i < answerCnt; i++)
        {
			randomNumber = Random.Range(0, buttonCnt);
            corAL.Add(new CorrectAnswerList(randomNumber));
        }
        cEnemyColors.getAnswerList(corAL);
        cEnemyColors.changeColor(0);
        chkAns.getAnswerList(corAL);
        //chkAns.moveCurrentAnswerPos();
    }

	public void MakeReactionAnswer(){
		IntAnswerId = Random.Range(0, buttonCnt);
		cEnemyColors.changeReactionColor(IntAnswerId);
	}
}
