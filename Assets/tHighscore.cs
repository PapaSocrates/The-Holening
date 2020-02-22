using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tHighscore : MonoBehaviour
{
    public TextMeshProUGUI tscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tscore.text = globals.highscore.ToString();
    }
}
