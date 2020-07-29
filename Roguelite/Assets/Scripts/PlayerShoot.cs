using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject gunObject;
    public Transform bulletPoint;
    private Transform gunPos;
    private Gun gun;
    private Bullet bullet;
    void Start()
    {
        gun = gunObject.GetComponent<GunDisplay>().gun;
        gunPos = gunObject.transform;
        bullet = gun.bullet;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            for (int i = 0; i < bullet.shotAmount; i++)
            {
                GameObject bulletClone = new GameObject("bullet");
                BulletDisplay bd = bulletClone.AddComponent<BulletDisplay>();
                bd.bullet = bullet;
                bulletClone.AddComponent<BulletPhysics>();
                bulletClone.transform.position = bulletPoint.position;
                bulletClone.transform.rotation = gunPos.rotation;
                bulletClone.transform.localScale = new Vector3(bullet.scaleX, bullet.scaleY, bullet.scaleZ);
                Rigidbody2D rb = bulletClone.AddComponent<Rigidbody2D>();
                rb.AddForce(bulletClone.transform.right * gun.bulletForce, ForceMode2D.Impulse);
            }
            AudioManager.PlaySound("gunshot");
        }
    }
}
