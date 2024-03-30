using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFly : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    Rigidbody ball;

    private void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    private void SphereLauch()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().AddForce(x, y, z, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            if (ball.mass >= collision.rigidbody.mass && ball.velocity.z >= 0.5)
            {
                collision.gameObject.SetActive(false);
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SphereLauch();
        }
    }
}
