using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, 5, ForceMode.VelocityChange);
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = Vector3.right;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
        Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Lost");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Box")
        {
            Debug.Log("Wow!");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Lost");
    }
}
