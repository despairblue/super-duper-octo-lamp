using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartOnClick : MonoBehaviour {

    public Button yourButton;
    public GameObject titleScreen;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(load);
    }

    public void load()
    {
        //GameMaster.initNewGame();
        titleScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}
