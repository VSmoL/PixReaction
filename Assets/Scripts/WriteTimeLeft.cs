using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WriteTimeLeft : MonoBehaviour {

    float timeLeft;
	public static bool GameOver = false;
    public Text timeLeftText;

	// Update is called once per frame
	void Update () {
		if (!WriteTimeLeft.GameOver) {
			timeLeft += Time.deltaTime;
			timeLeftText.text = timeLeft.ToString("f2");
		}
	}
}
