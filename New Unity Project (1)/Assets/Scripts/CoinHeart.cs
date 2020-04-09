using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHeart : MonoBehaviour
{
    public int xpValue = 5;
    public float spinSpeed = 100f;

    void Update()
    {
        this.transform.Rotate(2f, 2f, Time.deltaTime * this.spinSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerMovement>().GainXP(xpValue);
            Destroy(this.gameObject);
        }



    }
}
