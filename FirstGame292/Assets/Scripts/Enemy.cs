using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] GameManager manager;
/*    private float destroyEnemyYCoord = -10;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.gameOver();
        }
        else
        {
            GameManager.instance.increaseScore(1);
        }
        Destroy(gameObject);
        Destroy(collision.gameObject);
        
        /*if (transform.position.y <= destroyEnemyYCoord)
        {
            Destroy(gameObject);
        }*/
    }
}
