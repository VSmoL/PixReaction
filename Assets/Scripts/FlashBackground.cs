using UnityEngine;
using System.Collections;

public class FlashBackground : MonoBehaviour {

	public GameObject background;

	public void rightAnswer(){
		background.GetComponent<Animator> ().Play ("changeColorGreen");
	}

	public void wrongAnswer(){
		background.GetComponent<Animator> ().Play ("changeColorRed");
	}
}
