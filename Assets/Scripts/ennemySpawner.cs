using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ennemySpawner : MonoBehaviour
{
    public ennemy myEnnemy;
    public pattern myPattern;
    public warner myWarning;
    public int nbEnnemy;
    public Transform myPlayer;
    public boss myBoss;
    public int wave=4;
    // Start is called before the first frame update
    void Start()
    {
        Spawner();
        wave = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if(nbEnnemy <= 0 && wave <5)
        {
            
            Spawner();
        }
        if (nbEnnemy <= 0 && wave >= 5)
        {
            Boss();
        }
        

    }

    public void Spawner()
    {
        for (int j = 0; j < 4; j++)
        {
            for (int i = -7; i < 5; i++)
            {
                Instantiate(myEnnemy, new Vector3(2+1.2f*i, j, 0), Quaternion.identity);
                print("un de plus");
                nbEnnemy++;
            }
        }
        
        wave++;
        print(wave);
    }

    public void Boss()
    {
        Instantiate(myBoss, new Vector3(0,0,0), Quaternion.identity);
        nbEnnemy++;
        wave = 0;
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
