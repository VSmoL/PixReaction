using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ChangeEnemyColors : MonoBehaviour {

    public GameObject leftBtn;
	public GameObject leftBtn1;
	public GameObject leftBtn2;
    public GameObject rightBtn;
	public GameObject rightBtn1;
	public GameObject rightBtn2;

    private List<CorrectAnswerList> corAL = new List<CorrectAnswerList>();

    public void getAnswerList(List<CorrectAnswerList> sentList)
    {
        corAL = sentList;
    }

	public void changeColor(int answerTime)
	{
		if (answerTime >= corAL.Count) {
			leftBtn.GetComponent<Button>().interactable = false;
			leftBtn1.GetComponent<Button>().interactable = false;
			leftBtn2.GetComponent<Button>().interactable = false;
			rightBtn.GetComponent<Button>().interactable = false;
			rightBtn1.GetComponent<Button>().interactable = false;
			rightBtn2.GetComponent<Button>().interactable = false;
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
			else if (corAL[answerTime].answerId == 2)
			{
				Color tmpColor = new Color(leftBtn1.GetComponent<Image>().color.r, leftBtn1.GetComponent<Image>().color.g, leftBtn1.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
				transform.gameObject.GetComponent<Image>().color = tmpColor;
			}
			else if (corAL[answerTime].answerId == 3)
			{
				Color tmpColor = new Color(rightBtn1.GetComponent<Image>().color.r, rightBtn1.GetComponent<Image>().color.g, rightBtn1.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
				transform.gameObject.GetComponent<Image>().color = tmpColor;
			}
			else if (corAL[answerTime].answerId == 4)
			{
				Color tmpColor = new Color(leftBtn2.GetComponent<Image>().color.r, leftBtn2.GetComponent<Image>().color.g, leftBtn2.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
				transform.gameObject.GetComponent<Image>().color = tmpColor;
			}
			else if (corAL[answerTime].answerId == 5)
			{
				Color tmpColor = new Color(rightBtn2.GetComponent<Image>().color.r, rightBtn2.GetComponent<Image>().color.g, rightBtn2.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
				transform.gameObject.GetComponent<Image>().color = tmpColor;
			}
		}
	}
	public void changeReactionColor(int IntAnswer){
		if (IntAnswer == 0)
		{
			Color tmpColor = new Color(leftBtn.GetComponent<Image>().color.r, leftBtn.GetComponent<Image>().color.g, leftBtn.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
			transform.gameObject.GetComponent<Image>().color = tmpColor;
		}
		else if (IntAnswer == 1)
		{
			Color tmpColor = new Color(rightBtn.GetComponent<Image>().color.r, rightBtn.GetComponent<Image>().color.g, rightBtn.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
			transform.gameObject.GetComponent<Image>().color = tmpColor;
		}
		else if (IntAnswer == 2)
		{
			Color tmpColor = new Color(leftBtn1.GetComponent<Image>().color.r, leftBtn1.GetComponent<Image>().color.g, leftBtn1.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
			transform.gameObject.GetComponent<Image>().color = tmpColor;
		}
		else if (IntAnswer == 3)
		{
			Color tmpColor = new Color(rightBtn1.GetComponent<Image>().color.r, rightBtn1.GetComponent<Image>().color.g, rightBtn1.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
			transform.gameObject.GetComponent<Image>().color = tmpColor;
		}
		else if (IntAnswer == 4)
		{
			Color tmpColor = new Color(leftBtn2.GetComponent<Image>().color.r, leftBtn2.GetComponent<Image>().color.g, leftBtn2.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
			transform.gameObject.GetComponent<Image>().color = tmpColor;
		}
		else if (IntAnswer == 5)
		{
			Color tmpColor = new Color(rightBtn2.GetComponent<Image>().color.r, rightBtn2.GetComponent<Image>().color.g, rightBtn2.GetComponent<Image>().color.b, transform.gameObject.GetComponent<Image>().color.a);
			transform.gameObject.GetComponent<Image>().color = tmpColor;
		}
	}
}
