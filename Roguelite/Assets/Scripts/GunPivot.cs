using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class GunPivot : MonoBehaviour
{
    private GameObject gunObject;
    private Gun gun;
    void Start()
    {
        gunObject = gameObject.GetComponent<CharacterDisplay>().pickedGun;
        gun = gunObject.GetComponent<GunDisplay>().gun;
    }
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - gunObject.transform.position;
        Vector3 playerDiff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        playerDiff.z = 0;
        playerDiff.Normalize();
        difference.Normalize();
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        if (Vector2.Distance(Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.position) > gun.holdRadius + 0.05f)
        {
            gunObject.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
            gunObject.transform.position = transform.position + (gun.holdRadius * playerDiff);
        }
    }
}
