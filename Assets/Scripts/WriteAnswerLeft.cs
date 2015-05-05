using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WriteAnswerLeft : MonoBehaviour {

	public Text answerLeftText;
	int answers = 0;
	public MakeAnswers MA;

	void Start(){	
		answerLeftText.text = answers + "/" + MA.answerCnt; 
	}

	public void writeAnsLeft(){
		answers += 1;
		answerLeftText.text = answers + "/" + MA.answerCnt; 
	}
}
