using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorfollow : MonoBehaviour
{
    void Update()
    {
        transform.LookAt(Camera.main.WorldToScreenPoint(Input.mousePosition));
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(-angle, Vector3.up);
    }
}
