using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartCountdown : MonoBehaviour {

	public Text startCD;
	public MakeAnswers mAnswers;
	public GameObject answerObject;
	public GameObject answerCircle;
	public static float yieldTime = 1;
	public static float pitchSpeed = 1;

	public Button leftBtn;
	public Button leftBtn1;
	public Button leftBtn2;
	public Button rightBtn;
	public Button rightBtn1;
	public Button rightBtn2;

	public GameObject leftButton;
	public GameObject leftButton1;
	public GameObject leftButton2;
	public GameObject rightButton;
	public GameObject rightButton1;
	public GameObject rightButton2;

	public GameObject countdownSoundEffect;

	void Start(){
		checkDifficult ();
		if (GameStart.GameModeReaction) {
			StartCoroutine(reactionFirstTimeCountdown());
		} else if (GameStart.GameModeTimed) {
			StartCoroutine(TimedCountdown());
		}
	}

	public IEnumerator TimedCountdown () {
		transform.gameObject.SetActive (true);

		leftBtn.GetComponent<Button>().interactable = false;
		leftBtn1.GetComponent<Button>().interactable = false;
		leftBtn2.GetComponent<Button>().interactable = false;
		rightBtn.GetComponent<Button>().interactable = false;
		rightBtn1.GetComponent<Button>().interactable = false;
		rightBtn2.GetComponent<Button>().interactable = false;

		startCD.text = "3";
		countdownSoundEffect.GetComponent<AudioSource> ().clip = countdownSoundEffect.GetComponent<SoundEffectList> ().soundEffects [0];
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds(1);

		startCD.text = "2";
		countdownSoundEffect.GetComponent<AudioSource> ().clip = countdownSoundEffect.GetComponent<SoundEffectList> ().soundEffects [0];
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds(1);

		startCD.text = "1";
		countdownSoundEffect.GetComponent<AudioSource> ().clip = countdownSoundEffect.GetComponent<SoundEffectList> ().soundEffects [0];
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds(1);

		countdownSoundEffect.GetComponent<AudioSource> ().clip = countdownSoundEffect.GetComponent<SoundEffectList> ().soundEffects [1];
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();

		transform.gameObject.SetActive (false);
		mAnswers.getButtonCntTimed ();
		answerObject.SetActive (true);

		leftBtn.GetComponent<Button>().interactable = true;
		leftBtn1.GetComponent<Button>().interactable = true;
		leftBtn2.GetComponent<Button>().interactable = true;
		rightBtn.GetComponent<Button>().interactable = true;
		rightBtn1.GetComponent<Button>().interactable = true;
		rightBtn2.GetComponent<Button>().interactable = true;
	}

	public IEnumerator reactionFirstTimeCountdown(){
		leftBtn.GetComponent<Button>().interactable = false;
		leftBtn1.GetComponent<Button>().interactable = false;
		leftBtn2.GetComponent<Button>().interactable = false;
		rightBtn.GetComponent<Button>().interactable = false;
		rightBtn1.GetComponent<Button>().interactable = false;
		rightBtn2.GetComponent<Button>().interactable = false;
		
		startCD.text = "3";
		countdownSoundEffect.GetComponent<AudioSource> ().clip = countdownSoundEffect.GetComponent<SoundEffectList> ().soundEffects [0];
		countdownSoundEffect.GetComponent<AudioSource> ().pitch = pitchSpeed;
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds(yieldTime);

		startCD.text = "2";
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds(yieldTime);

		startCD.text = "1";
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds(yieldTime);

		countdownSoundEffect.GetComponent<AudioSource> ().clip = countdownSoundEffect.GetComponent<SoundEffectList> ().soundEffects [1];
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();

		yieldTime = yieldTime * 0.95f;
		pitchSpeed = pitchSpeed * 1.05f;
		
		leftBtn.GetComponent<Button>().interactable = true;
		leftBtn1.GetComponent<Button>().interactable = true;
		leftBtn2.GetComponent<Button>().interactable = true;
		rightBtn.GetComponent<Button>().interactable = true;
		rightBtn1.GetComponent<Button>().interactable = true;
		rightBtn2.GetComponent<Button>().interactable = true;

		mAnswers.getButtonCntReaction ();

		WriteTimeLeft.stopReactionTimer = true;
		transform.gameObject.SetActive (false);
		answerObject.SetActive (true);
	}

	public IEnumerator reactionTimeCountdown(){
		transform.gameObject.SetActive (true);
		answerCircle.SetActive (false);

		mAnswers.MakeReactionAnswer ();

		leftBtn.GetComponent<Button>().interactable = false;
		leftBtn1.GetComponent<Button>().interactable = false;
		leftBtn2.GetComponent<Button>().interactable = false;
		rightBtn.GetComponent<Button>().interactable = false;
		rightBtn1.GetComponent<Button>().interactable = false;
		rightBtn2.GetComponent<Button>().interactable = false;

		startCD.text = "3";
		countdownSoundEffect.GetComponent<AudioSource> ().clip = countdownSoundEffect.GetComponent<SoundEffectList> ().soundEffects [0];
		countdownSoundEffect.GetComponent<AudioSource> ().pitch = pitchSpeed;
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds(yieldTime);

		startCD.text = "2";
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds(yieldTime);

		startCD.text = "1";
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds(yieldTime);

		countdownSoundEffect.GetComponent<AudioSource> ().clip = countdownSoundEffect.GetComponent<SoundEffectList> ().soundEffects [1];
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();


		yieldTime = yieldTime * 0.95f;
		pitchSpeed = pitchSpeed * 1.05f;

		leftBtn.GetComponent<Button>().interactable = true;
		leftBtn1.GetComponent<Button>().interactable = true;
		leftBtn2.GetComponent<Button>().interactable = true;
		rightBtn.GetComponent<Button>().interactable = true;
		rightBtn1.GetComponent<Button>().interactable = true;
		rightBtn2.GetComponent<Button>().interactable = true;

		WriteTimeLeft.stopReactionTimer = true;
		transform.gameObject.SetActive (false);
		answerCircle.SetActive (true);
	}

	void checkDifficult(){
		int difficultNumber = PlayerPrefs.GetInt ("DifficultInt", 1);

		if (difficultNumber == 1) {

			leftButton.SetActive(true);
			leftButton1.SetActive(false);
			leftButton2.SetActive(false);
			rightButton.SetActive(true);
			rightButton1.SetActive(false);
			rightButton2.SetActive(false);
		} 
		else if (difficultNumber == 2) {
			leftButton.SetActive(true);
			leftButton1.SetActive(true);
			leftButton2.SetActive(false);
			rightButton.SetActive(true);
			rightButton1.SetActive(true);
			rightButton2.SetActive(false);
		} 
		else if (difficultNumber == 3) {
			leftButton.SetActive(true);
			leftButton1.SetActive(true);
			leftButton2.SetActive(true);
			rightButton.SetActive(true);
			rightButton1.SetActive(true);
			rightButton2.SetActive(true);
		}
	}

	public void playLoseSound(){
		countdownSoundEffect.GetComponent<AudioSource> ().clip = countdownSoundEffect.GetComponent<SoundEffectList> ().soundEffects [2];
		countdownSoundEffect.GetComponent<AudioSource> ().pitch = 1;
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
	}
	public void playWinSound(){
		countdownSoundEffect.GetComponent<AudioSource> ().clip = countdownSoundEffect.GetComponent<SoundEffectList> ().soundEffects [3];
		countdownSoundEffect.GetComponent<AudioSource> ().pitch = 1;
		countdownSoundEffect.GetComponent<AudioSource> ().Play ();
	}
}
