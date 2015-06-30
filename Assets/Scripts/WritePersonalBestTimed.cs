using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WritePersonalBestTimed : MonoBehaviour {

	public Text personalBestTimed;

	// Use this for initialization
	void OnEnable(){
		personalBestTimed.text = "Best: " + PlayerPrefs.GetFloat ("PlayerTopTimed",999.99f).ToString ("f2");
	}
}
