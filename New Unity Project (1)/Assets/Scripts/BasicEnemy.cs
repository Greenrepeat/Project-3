using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public Transform target;
    private float speed = 3f;
    private float attack1Range = 1f;
    public int attack1Damage = 1;
    public float timeBetweenAttacks;

    public void SettimeBetweenAttacks(float value)
    {
        SettimeBetweenAttacks(value);
    }

    void Start()
    {
        Rest();
    }

    void Update()
    {

    }

    public void MoveToPlayer()
    {
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        if (Vector3.Distance(transform.position, target.position) > attack1Range)
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
    }

    public void Rest()
    {

    }
}