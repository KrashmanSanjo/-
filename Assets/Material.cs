using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material : MonoBehaviour
{
    Rigidbody material;
    public float density;

    private void Start()
    {
        material = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            if (material.mass <= collision.rigidbody.mass && collision.rigidbody.velocity.z >= material.mass*3.45)
            {
                material.gameObject.SetActive(false);
            }
        }
    }
}
