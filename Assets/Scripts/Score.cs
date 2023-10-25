using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int scoreActuel = 0;

    public void AddScore(int valeur)
    {
        scoreActuel += valeur;

        print("J'ai" + scoreActuel + " points.");
    }
}
