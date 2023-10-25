using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ennemy : MonoBehaviour
{

    public Rigidbody2D ennemiBody;
    public Transform ennemiTransform;
    public Vector3 left = new Vector3(2, 0, 0);
    public Vector3 right = new Vector3(-2,0,0);
    public bool goingLeft;
    public float timePassed=0f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        ennemiBody.velocity = left;
        


    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;



        if (timer >3 )
        {
            ennemiBody.position = new Vector3(ennemiBody.position.x, ennemiBody.position.y - 1, 0);
            timer = 0;
        }
        


        if (ennemiBody.position.x < -9)
        {
            ennemiBody.position = new Vector3(9, ennemiBody.position.y, 0);
           
        }
        if (ennemiBody.position.x > 9)
        {
            ennemiBody.position = new Vector3(-9, ennemiBody.position.y, 0);
            
        }

        
       
    }
}
