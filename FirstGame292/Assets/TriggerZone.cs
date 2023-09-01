using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Entered!");
        collision.gameObject.transform.localScale = new Vector3(2, 2, 2);
        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        //collision.gameObject.GetComponent<Player>().UpSpeed(3);
        player.UpSpeed(20);
        player.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger Exited!");
        collision.gameObject.transform.localScale = new Vector3(1, 1, 1);
        if (collision.gameObject.GetComponent<Player>())
        {
            collision.gameObject.GetComponent<Player>().UpSpeed(-3);
        }
    }
}
