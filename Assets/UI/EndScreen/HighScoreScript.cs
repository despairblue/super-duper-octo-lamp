using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour {

    [SerializeField]
    Text text;
    // Use this for initialization
    void Start () {
        text.text = PlayerPrefs.GetInt("highscore").ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
