using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerenemy : MonoBehaviour
{
    public int numObjects = 0;
    public GameObject enemy;
    float next_spawn;
    public float rate_spawn = 1;
    void Update()
    {
        if (Time.time > next_spawn)
        {
            numObjects += 1;
            Vector3 center = transform.position;
            for (int i = 0; i < numObjects; i++)
            {
                Vector3 pos = RandomCircle(center, 12f);
                Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center);
                Instantiate(enemy, pos, Quaternion.identity);
                numObjects = 0;
            }
            next_spawn = Time.time + rate_spawn;
        }

    }
    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + 1;
        pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        return pos;
    }
}
