using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletvroom : MonoBehaviour
{
    public int speed = 35;
    void Update()
    {
        transform.Translate(new Vector3 (1, 0, 0) * Time.unscaledDeltaTime * speed);
        Destroy(gameObject, 3);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("UI"))
        {
            Destroy(gameObject);
        }
    }
}
