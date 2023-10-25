using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Drop monCadeau;
    public ennemySpawner ennemyData;
    public Score monScore;
    public Rigidbody2D monRigidBody;
    public float speed;
    public GameObject monBonus;
    public MovementEtTir monJoueur;
    // Start is called before the first frame update
    void Start()
    {
        

        monScore = FindObjectOfType<Score>();

        ennemyData = FindObjectOfType<ennemySpawner>();

        monJoueur = FindObjectOfType<MovementEtTir>();

        if (!monJoueur.isUp)
        {
            monRigidBody.velocity = Vector3.up * speed;
        }
        else
        {
            monRigidBody.velocity = Vector3.down * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ennemy") { 
            Destroy(collision.gameObject);
            ennemyData.nbEnnemy--;
            

                monCadeau.monDrop();
            

                monScore.AddScore(10);

        }

       



        

        Destroy(gameObject);
    }

}
