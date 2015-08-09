using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WritePersonalBestReaction : MonoBehaviour {

	public Text personalBestReaction;

	public void reactionTopRefresh(string difficult){
		personalBestReaction.text = "Best: " + PlayerPrefs.GetInt ("PlayerTopReaction"+difficult);
	}
}
