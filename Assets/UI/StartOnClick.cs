using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartOnClick : MonoBehaviour {

    public Button yourButton;
    public Image titleScreen;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(load);
    }

    

    public void load()
    {
        titleScreen.enabled = false;
    }
}
