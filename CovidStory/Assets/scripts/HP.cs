using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HP : MonoBehaviour
{
    public Image HP_BAR;
    public float hp; // health point
    public float counter = 0f; // number of miss
    // Start is called before the first frame update
    void Start()
    {
        hp = 96f;
    }

    // Update is called once per frame
    void Update()
    {
        float num = (hp - 9.2f * counter) / 100f;
        if (num > 0)
            HP_BAR.fillAmount = num;
        else // GAME OVER
            HP_BAR.fillAmount = 0f;
    }
}
