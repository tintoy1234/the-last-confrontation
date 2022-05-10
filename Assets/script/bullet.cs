using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject balle;
    public float fireRate; 
    private float nextFire;
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(balle, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.50f, gameObject.transform.position.z), gameObject.transform.rotation);
        }
    }
}
