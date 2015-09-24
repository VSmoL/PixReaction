using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WriteTimeLeft : MonoBehaviour {

    public static float totalTime;
	float timeLeft = 3.0f;
	float tempTimeLeft;
	public static bool GameOver = false;
	public static bool stopReactionTimer;
    public Text timeLeftText;

	public FlashBackground FB;
	public GameOver GO;
	public StartCountdown SC;

	public void Start(){
		timeLeft = 3.0f;
		tempTimeLeft = timeLeft;
		totalTime = 0;
	}

	// Update is called once per frame
	void Update () {
		if (GameStart.GameOn) {
			if(GameStart.GameModeReaction){
				if(stopReactionTimer){
					tempTimeLeft -= Time.deltaTime;
					timeLeftText.text = tempTimeLeft.ToString("f2");
					if(tempTimeLeft <= 0){
						timeLeftText.text = 0.ToString("f2");
						WriteTimeLeft.GameOver = true;
						FB.wrongAnswer();
						SC.playLoseSound();
						GO.GameOverSaveDataReaction();
					}
				}
			}
			else if(GameStart.GameModeTimed){
				totalTime += Time.deltaTime;
				timeLeftText.text = totalTime.ToString("f2");
			}
		}
	}
	public void answerRight(){
		stopReactionTimer = false;
		timeLeft = timeLeft*0.9f;
		tempTimeLeft = timeLeft;
	}
}
