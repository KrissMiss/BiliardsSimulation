using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "hole")
        {
            gameObject.GetComponent<Collider>().isTrigger = true;
        }
    }
}
