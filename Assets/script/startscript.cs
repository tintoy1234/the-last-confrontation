using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startscript : MonoBehaviour
{
    public GameObject quit;
    public GameObject spawner;
    public bullet script;
    public GameObject logo;
    public bulletinstartscreen script1;
    private void Start()
    {
        spawner.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            logo.SetActive(false);
            spawner.SetActive(true);
            gameObject.SetActive(false);
            quit.SetActive(false);
            script1.enabled = false;
            script.enabled = true;
        }
    }
}
