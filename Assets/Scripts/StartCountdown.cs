using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartCountdown : MonoBehaviour {

	public Text startCD;
	public MakeAnswers mAnswers;
	public GameObject answerObject;
	public GameObject answerCircle;
	public static float yieldTime = 1;

	public Button leftBtn;
	public Button rightBtn;

	void Start(){
		if (GameStart.GameModeReaction) {
			StartCoroutine(reactionFirstTimeCountdown());
		} else if (GameStart.GameModeTimed) {
			StartCoroutine(TimedCountdown());
		}
	}

	public IEnumerator TimedCountdown () {
		transform.gameObject.SetActive (true);

		leftBtn.GetComponent<Button>().interactable = false;
		rightBtn.GetComponent<Button>().interactable = false;

		startCD.text = "3";
		yield return new WaitForSeconds(1);
		startCD.text = "2";
		yield return new WaitForSeconds(1);
		startCD.text = "1";
		yield return new WaitForSeconds(1);

		transform.gameObject.SetActive (false);
		mAnswers.MakeAnswerList ();
		answerObject.SetActive (true);

		leftBtn.GetComponent<Button>().interactable = true;
		rightBtn.GetComponent<Button>().interactable = true;
	}

	public IEnumerator reactionFirstTimeCountdown(){
		leftBtn.GetComponent<Button>().interactable = false;
		rightBtn.GetComponent<Button>().interactable = false;
		
		startCD.text = "3";
		yield return new WaitForSeconds(yieldTime);
		startCD.text = "2";
		yield return new WaitForSeconds(yieldTime);
		startCD.text = "1";
		yield return new WaitForSeconds(yieldTime);
		
		yieldTime = yieldTime * 0.95f;
		
		leftBtn.interactable = true;
		rightBtn.interactable = true;

		mAnswers.MakeReactionAnswer ();

		WriteTimeLeft.stopReactionTimer = true;
		transform.gameObject.SetActive (false);
		answerObject.SetActive (true);
	}

	public IEnumerator reactionTimeCountdown(){
		transform.gameObject.SetActive (true);
		answerCircle.SetActive (false);

		mAnswers.MakeReactionAnswer ();

		leftBtn.GetComponent<Button>().interactable = false;
		rightBtn.GetComponent<Button>().interactable = false;

		startCD.text = "3";
		yield return new WaitForSeconds(yieldTime);
		startCD.text = "2";
		yield return new WaitForSeconds(yieldTime);
		startCD.text = "1";
		yield return new WaitForSeconds(yieldTime);

		yieldTime = yieldTime * 0.95f;

		leftBtn.interactable = true;
		rightBtn.interactable = true;

		WriteTimeLeft.stopReactionTimer = true;
		transform.gameObject.SetActive (false);
		answerCircle.SetActive (true);
	}
}
