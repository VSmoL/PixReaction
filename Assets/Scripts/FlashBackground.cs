using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FlashBackground : MonoBehaviour {

	public GameObject background;
	public Button leftBtn;
	public Button rightBtn;
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
		rightBtn.interactable = false;
	}
}
