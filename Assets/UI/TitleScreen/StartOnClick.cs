using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartOnClick : MonoBehaviour {

    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(load);
    }

    public void load()
    {
        SceneManager.LoadScene("level1");
    }
}
