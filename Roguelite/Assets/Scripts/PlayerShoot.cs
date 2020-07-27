using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform gunPoint;
    public Transform armPivot;
    public GameObject bullet;
    public AudioSource gunshotSFX;
    public float bulletForce = 1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bulletClone = Instantiate(bullet);
            bulletClone.GetComponent<BulletPhysics>().enabled = true;
            bulletClone.transform.position = gunPoint.position;
            bulletClone.transform.rotation = armPivot.rotation;
            Rigidbody2D rb = bulletClone.GetComponent<Rigidbody2D>();
            rb.AddForce(bulletClone.transform.right*bulletForce, ForceMode2D.Impulse);
            gunshotSFX.PlayOneShot(gunshotSFX.clip);
        }
    }
}
