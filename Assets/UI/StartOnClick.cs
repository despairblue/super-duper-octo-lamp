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
        titleScreen = titleScreen.GetComponent<Image>();
    }

    public void load()
    {
        titleScreen.enabled = false;

        for (int i = 0; i < titleScreen.transform.childCount; i++)
        {
            var child = titleScreen.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
    }
}
