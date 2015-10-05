using UnityEngine;
using System.Collections;

public class AndroidBackButton : MonoBehaviour {

	public int sceneID;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(sceneID == 0){
				Application.Quit();
			}
			else if (sceneID == 1){
				Application.LoadLevel("MainMenu");	
			}
		}
	}
}
