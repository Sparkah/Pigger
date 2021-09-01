using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    private GameObject Player;
    private Rigidbody2D Dog;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Dog = GetComponent<Rigidbody2D>();
        speed = 0.05f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Dog.AddForce(new Vector2(Player.transform.position.x - Dog.transform.position.x, Player.transform.position.y - Dog.transform.position.y) * speed);
    }
}
