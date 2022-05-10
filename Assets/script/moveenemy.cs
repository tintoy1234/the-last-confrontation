using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveenemy : MonoBehaviour
{
    public int speed = 5;
    void FixedUpdate()
    {
        transform.LookAt(new Vector3(0,0,0));
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(gameObject);
        }
    }
}
