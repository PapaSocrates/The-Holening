using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tMaxScore : MonoBehaviour
{
    public TextMeshProUGUI tmaxcore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tmaxcore.text = ("Record score: " + globals.maxscore.ToString());
    }
}

