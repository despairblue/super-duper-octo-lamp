using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenScript : MonoBehaviour {

    public GameObject TitleScreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (TitleScreen.activeSelf == true) {
            Time.timeScale = 0f;
        }
        
    }
}
