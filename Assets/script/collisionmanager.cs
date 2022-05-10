using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionmanager : MonoBehaviour
{
    public GameObject canvasgameover;
    public void Start()
    {
        canvasgameover.SetActive(false);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            canvasgameover.SetActive(true);
        }
    }
}


