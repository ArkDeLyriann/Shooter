using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;
    public Score monScore;
    private Vector3 monte;
    private Vector3 descends;
    private int laDistance = 1;

    public bool isUp = false;

    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        monScore = FindObjectOfType<Score>();

    }

    // Update is called once per frame
    void Update()
    {

        monte = transform.TransformPoint(Vector3.up * laDistance);
        descends = transform.TransformPoint(Vector3.down * -laDistance);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right*speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!isUp)
            {
                transform.position = new Vector3 (transform.position.x, 4.5f, transform.position.z);
                transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 180);
                isUp = true;
            }
            else
            {
                transform.position = new Vector3(transform.position.x, -4.5f, transform.position.z);
                transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 0);
                isUp = false;
            }
        }

        if (transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ennemy")
        {
            SceneManager.LoadScene("SampleScene");
            

        }


    }

    public void Shoot()
    {
    
        if(monScore.scoreActuel < 500) {    
            if (!isUp)
            {
                Instantiate(bullet, monte, parent.rotation);
            }
            else
            {
                Instantiate(bullet, descends, parent.rotation);
            }
        }
        if(monScore.scoreActuel > 500 )//&& monScore.scoreActuel < 1000)
        {
            if (!isUp)
            {
                Instantiate(bullet, monte+Vector3.left*0.5f, parent.rotation);
                Instantiate(bullet, monte+Vector3.right*0.5f, parent.rotation);

            }
            else
            {
                Instantiate(bullet, descends + Vector3.left * 0.5f, parent.rotation);
                Instantiate(bullet, descends + Vector3.right * 0.5f, parent.rotation);
            }
        }
    }
}
