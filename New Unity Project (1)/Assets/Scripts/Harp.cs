using UnityEngine;

public class Harp : MonoBehaviour
{


    // changing the damage and range the harp can use with float statements
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;


    // Update is called once per frame
    void Update()
    {
        // Fire1 in unity is coded to be left mouse button
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }


    }

    void shoot()
    {
        // detects if something was hit by the invisible ray
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }

}
