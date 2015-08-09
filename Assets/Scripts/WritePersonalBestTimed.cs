using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WritePersonalBestTimed : MonoBehaviour {

	public Text personalBestTimed;

	public void timedTopRefresh(string difficult){
		personalBestTimed.text = "Best: " + PlayerPrefs.GetFloat ("PlayerTopTimed"+difficult,999.99f).ToString ("f2");
	}
}
