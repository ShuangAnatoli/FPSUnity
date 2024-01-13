using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //If we hit the tag Target it is collision
        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("hit " + collision.gameObject.name + " !");
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("hit the wall!");
            Destroy(gameObject);
        }

    }
}