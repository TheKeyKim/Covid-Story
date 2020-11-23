using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Combo : MonoBehaviour
{
    public Text num;
    public float combo = 0f; // number of hit combo
    // Start is called before the first frame update
    void Start()
    {
        num.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        num.text = combo.ToString();
    }
}
