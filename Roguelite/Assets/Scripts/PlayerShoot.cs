using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject gunObject;
    public GameObject bullet;
    public Transform bulletPoint;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bulletClone = Instantiate(bullet);
            bulletClone.GetComponent<BulletPhysics>().enabled = true;
            bulletClone.GetComponent<Rigidbody2D>().simulated = true;
            bulletClone.transform.position = bulletPoint.position;
            bulletClone.transform.rotation = gunObject.transform.rotation;
            Rigidbody2D rb = bulletClone.GetComponent<Rigidbody2D>();
            rb.AddForce(bulletClone.transform.right*gunObject.GetComponent<GunDisplay>().gun.bulletForce, ForceMode2D.Impulse);
            AudioManager.PlaySound("gunshot");
        }
    }
}
