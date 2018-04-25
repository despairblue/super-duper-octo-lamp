using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaveOnClick : MonoBehaviour {
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(Quit);
    }

    public void Quit()
    {
            Application.Quit();
    }
}
