using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInstanciator : MonoBehaviour
{
    [SerializeField]
    private GameObject Bomb;
    [SerializeField]
    private GameObject BackGround;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") || collision.CompareTag("Respawn"))
        {
            PlantBomb();
            Destroy(gameObject);
        }

        if(collision.CompareTag("Wall"))
        {
            PlantBomb();
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            PlantBomb();
            Destroy(gameObject);
        }
    }

    private void PlantBomb()
    {
        Instantiate(Bomb, new Vector3(UnityEngine.Random.Range(Screen.width/10,Screen.width/1.2f), UnityEngine.Random.Range(Screen.height/10, Screen.height/1.2f),0), Quaternion.identity, BackGround.GetComponent<Transform>());
    }
}