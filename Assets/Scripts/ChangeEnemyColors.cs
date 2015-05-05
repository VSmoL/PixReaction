using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ChangeEnemyColors : MonoBehaviour {

    public GameObject leftBtn;
    public GameObject rightBtn;

    private List<CorrectAnswerList> corAL = new List<CorrectAnswerList>();

    public void getAnswerList(List<CorrectAnswerList> sentList)
    {
        corAL = sentList;
    }

	public void changeColor(int answerTime)
	{
		print (answerTime);
		if (answerTime >= corAL.Count) {
			leftBtn.GetComponent<Button>().interactable = false;
			rightBtn.GetComponent<Button>().interactable = false;
			WriteTimeLeft.GameOver = true;
		} 
		else {
			if (corAL[answerTime].answerId == 0)
			{
				Color tmpColor = new Color(leftBtn.GetComponent<Image>().color.r, leftBtn.GetComponent<Image>().color.g, leftBtn.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
				transform.gameObject.GetComponent<Image>().color = tmpColor;
			}
			else if (corAL[answerTime].answerId == 1)
			{
				Color tmpColor = new Color(rightBtn.GetComponent<Image>().color.r, rightBtn.GetComponent<Image>().color.g, rightBtn.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
				transform.gameObject.GetComponent<Image>().color = tmpColor;
			}
		}
	}
}
