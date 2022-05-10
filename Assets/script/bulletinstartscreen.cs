using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletinstartscreen : MonoBehaviour
{
    public GameObject balle;
    public bullet script;
    // Start is called before the first frame update
    void Start()
    {
        script.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(balle, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.50f, gameObject.transform.position.z), gameObject.transform.rotation);
        }
    }
}
