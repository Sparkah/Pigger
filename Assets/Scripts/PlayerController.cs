using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D Player;
    private int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Player.transform.position = Vector2.MoveTowards(transform.position, new Vector2(touch.position.x, touch.position.y), speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(0);
        }
        if(collision.CompareTag("Wall"))
        {
            speed = 0;
            Player.AddForce(new Vector2(Player.transform.position.x - collision.transform.position.x, Player.transform.position.y - collision.transform.position.y)*15);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            speed = 2;
        }
    }
}