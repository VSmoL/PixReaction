using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FlashBackground : MonoBehaviour {

	public GameObject background;
	public Button leftBtn;
	public Button leftBtn1;
	public Button leftBtn2;
	public Button rightBtn;
	public Button rightBtn1;
	public Button rightBtn2;
	public GameOver GO;

	public void rightAnswer(){
		background.GetComponent<Animator> ().Play ("changeColorGreen");
	}

	public void lastRightAnswer(){
		background.GetComponent<Animator> ().Play ("changeColorGreenEnd");
	}

	public void wrongAnswer(){
		background.GetComponent<Animator> ().Play ("changeColorRed");
		leftBtn.interactable = false;
		leftBtn1.interactable = false;
		leftBtn2.interactable = false;
		rightBtn.interactable = false;
		rightBtn1.interactable = false;
		rightBtn2.interactable = false;
	}
}
