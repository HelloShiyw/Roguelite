using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class GunPivot : MonoBehaviour
{
    public GameObject gun;
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - gun.transform.position;
        Vector3 playerDiff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        playerDiff.z = 0;
        playerDiff.Normalize();
        difference.Normalize();
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        if (Vector2.Distance(Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.position) > 1.55f)
        {
            gun.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
            gun.transform.position = transform.position + (1.5f * playerDiff);
        }
    }
}
