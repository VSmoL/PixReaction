using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WriteAnswerLeft : MonoBehaviour {

	public Text answerLeftText;
	static public int answers = 0;
	public MakeAnswers MA;

	void Start(){	
		if (GameStart.GameModeReaction) {
			answerLeftText.text = answers.ToString(); 
		}
		else if (GameStart.GameModeTimed){
			answerLeftText.text = answers + "/" + MA.answerCnt; 
		}
	}

	public void writeAnsLeft(){
		answers += 1;
		answerLeftText.text = answers + "/" + MA.answerCnt; 
	}

	public void writeAns(){
		answers += 1;
		answerLeftText.text = answers.ToString();
	}
}
