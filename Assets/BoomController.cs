using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomController : MonoBehaviour
{
    public float timeToExplode;
    public float power;
    public float radius;

    void Update()
    {
        timeToExplode -= Time.deltaTime;
        
        if(timeToExplode <= 0 )
        {
            Boom();
        }
    }

    void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody b in blocks ) 
        {
            if (Vector3.Distance(transform.position, b.transform.position) < radius)
            {
                Vector3 direction = b.transform.position - transform.position;

                b.AddForce(direction.normalized * power * (radius - Vector3.Distance(transform.position, b.transform.position)), ForceMode.Impulse);
            }
        }

        timeToExplode = 3;
    }
}
