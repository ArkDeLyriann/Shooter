using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ennemySpawner : MonoBehaviour
{
    public float timePassed = 0f;
    public ennemy myEnnemy;
    public pattern myPattern;
    public warner myWarning;
    public int nbEnnemy;
    public Transform myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        Spawner();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nbEnnemy <= 0)
        {
            Spawner();
        }
        timePassed += Time.deltaTime;
        if (timePassed == 10f)
        {
            Warn();
            
        }
        if (timePassed > 15f)
        {
            Dodge();
            timePassed = 0f;
        }

    }

    public void Spawner()
    {
        for (int j = 0; j < 4; j++)
        {
            for (int i = -9; i < 3; i++)
            {
                Instantiate(myEnnemy, new Vector3(2+1.2f*i, j, 0), Quaternion.identity);
                print("un de plus");
                nbEnnemy++;
            }
        }
       
        
    }

    public void Warn()
    {
        Instantiate(myWarning, new Vector3(0, myPlayer.position.y, 0), transform.rotation);
    }

    public void Dodge()
    {
        Instantiate(myPattern, new Vector3(0, myPlayer.position.y, 0), transform.rotation);
    }
}
