using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePointsScript : MonoBehaviour {
    [SerializeField]
    public Sprite zerolife;
    [SerializeField]
    public Sprite onelife;
    [SerializeField]
    public Sprite twolife;
    [SerializeField]
    public Sprite threelife;
    [SerializeField]
    public Sprite fourlife;
    [SerializeField]
    public Sprite fivelife;

    [SerializeField]
    int LifePoints;

    [SerializeField]
    Slider slider;

    [SerializeField]
    Image LifeAsAImage;

    [SerializeField]
    GameMaster gameMaster;

    // Use this for initialization
    void Start()
    {
        slider.maxValue = LifePoints;
        slider.value = gameMaster.getLifePoints();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = gameMaster.getLifePoints();
        float criteria = slider.value / slider.maxValue;
        print(criteria);
        if (criteria < 0)
        {
            LifeAsAImage.sprite = zerolife;
        }
        if (criteria > 0 && criteria < 0.20f) {
            LifeAsAImage.sprite = onelife;
        }
        if (criteria > 0.20f && criteria < 0.40f)
        {
            LifeAsAImage.sprite = twolife;
        }
        if (criteria > 0.40f && criteria < 0.60f)
        {
            LifeAsAImage.sprite = threelife;
        }
        if (criteria > 0.60f && criteria < 0.80f)
        {
            LifeAsAImage.sprite = fourlife;
        }
        if (criteria > 0.80f )
        {
            LifeAsAImage.sprite = fivelife;
        }
    }
}
