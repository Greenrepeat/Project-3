using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // serialization is used here to save it to memory, rather than a specific location.
    [SerializeField] private Transform player;

    [SerializeField] private Transform respawnPoint;


    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
    }
}
