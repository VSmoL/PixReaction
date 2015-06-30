using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WritePersonalBestReaction : MonoBehaviour {

	public Text personalBestReaction;
	
	// Use this for initialization
	void OnEnable(){
		personalBestReaction.text = "Best: " + PlayerPrefs.GetInt ("PlayerTopReaction");
	}
}
