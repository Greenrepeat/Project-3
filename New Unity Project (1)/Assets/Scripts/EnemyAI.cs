using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public BoxCollider territory;
    GameObject player;
    bool playerInTerritory;

    public GameObject enemy;
    BasicEnemy basicenemy;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInTerritory == true)
        {
            basicenemy.MoveToPlayer();
        }
        if (playerInTerritory == false)
        {
            basicenemy.Rest();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInTerritory = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInTerritory = false;
        }
    }
}