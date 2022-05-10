using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausescript : MonoBehaviour
{
    public GameObject resume;
    public GameObject quit;
    public GameObject home;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            resume.SetActive(true);
            quit.SetActive(true);
            home.SetActive(true);
        }
    }
}
