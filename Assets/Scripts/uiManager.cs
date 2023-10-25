using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uiManager : MonoBehaviour
{

    public Score monScore;
    public TextMeshProUGUI monUI;

    // Start is called before the first frame update
    void Start()
    {
        monScore = FindObjectOfType<Score>();
    }

    // Update is called once per frame 
    void Update()
    {
        monUI.text = "SCORE: " + monScore.scoreActuel;
    }
}
