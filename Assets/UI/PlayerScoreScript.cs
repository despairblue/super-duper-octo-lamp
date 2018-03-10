using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreScript : MonoBehaviour {

    [SerializeField]
    Text text;

    [SerializeField]
    GameMaster gameMaster;

    // Use this for initialization
    void Start () {
        text.text = "Player Score: " + gameMaster.getScore();		
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Player Score: " + gameMaster.getScore();
    }
}
