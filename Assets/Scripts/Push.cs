using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float power;
    float speed = 10;
    public void Psh()
    {
        Vector3 direction = new Vector3(1, 0, 0);
        GetComponent<Rigidbody>().AddForce(direction * power * speed, ForceMode.Impulse);
    }
}
