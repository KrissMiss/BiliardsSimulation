using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomScript : MonoBehaviour
{
    public float TimeToExplosion;
    public float Power;
    public float Radius;

    void Update()
    {
        TimeToExplosion -= Time.deltaTime;

        if (TimeToExplosion <= 0)
        {
            Boom();
        }
    }

    void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody item in blocks)
        {
            if (Vector3.Distance(transform.position, item.transform.position) < Radius)
            {
                Vector3 direction = item.transform.position - transform.position;

                item.AddForce(direction.normalized * Power * (Radius - Vector3.Distance(transform.position, item.transform.position)), ForceMode.Impulse);
            }
        }

        TimeToExplosion = 5;
    }
}
