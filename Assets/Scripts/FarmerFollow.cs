using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerFollow : MonoBehaviour
{
    private GameObject Player;
    private Transform Farmer;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Farmer = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Farmer.transform.position = Vector3.MoveTowards(transform.position, new Vector3(Player.transform.position.x, Player.transform.position.y, 0), speed);
    }
}
