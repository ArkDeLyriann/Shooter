using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public Score monScore;

    private void Start()
    {
        monScore = FindObjectOfType<Score>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            monScore.AddScore(100);

            Destroy(gameObject);

        }

        
    }

    

}
