using UnityEngine;
using System.Collections;

public class SpawnEnemyButtons : MonoBehaviour {

    public GameObject[] GroupButtons;
    public GameObject enemyBtn;
    public MakeAnswers changeBtnSprite;

	// Use this for initialization
	void Start () {
        GameObject grpBtn = (GameObject)Instantiate(GroupButtons[5], new Vector3(0,0,0), Quaternion.identity);
        grpBtn.transform.SetParent(enemyBtn.transform);
        //changeBtnSprite.changeSprite();
	}
}
