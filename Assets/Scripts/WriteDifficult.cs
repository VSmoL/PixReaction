using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WriteDifficult : MonoBehaviour {

	public Text DifficultText;

	public void DifficultWriteText(int difficultNumber){
		if (difficultNumber == 1) {
			DifficultText.text = "Easy";
		} 
		else if (difficultNumber == 2) {
			DifficultText.text = "Medium";	
		}
		else if (difficultNumber == 3) {
			DifficultText.text = "Hard";	
		}
	}
}
