using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.WorldToViewportPoint(transform.position);
        if ( pos.x < 0 || pos.y < 0 || pos.x > 1 || pos.y > 1)
        {
            Destroy(gameObject);
        }
        
    }
}
