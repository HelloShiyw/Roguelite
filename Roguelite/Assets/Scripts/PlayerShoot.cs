using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private GameObject gunObject;
    private Transform gunPos;
    private Transform bulletPoint;
    private Gun gun;
    private Bullet bullet;
    private float chargeTime = 0f;
    void Start()
    {
        gunObject = gameObject.GetComponent<CharacterDisplay>().pickedGun;
        bulletPoint = gameObject.GetComponent<CharacterDisplay>().gunPoint;
        gun = gunObject.GetComponent<GunDisplay>().gun;
        gunPos = gunObject.transform;
        bullet = gun.bullet;
    }
    // Update is called once per frame
    void Update()
    {
        chargeTime = Mathf.Clamp(chargeTime - Time.deltaTime, 0, gun.chargeTime);
        if (chargeTime <= 0 && Input.GetButton("Fire1"))
        {
            for (int i = 0; i < gun.shotAmount; i++)
            {
                GameObject bulletClone = new GameObject("bullet");
                BulletDisplay bd = bulletClone.AddComponent<BulletDisplay>();
                bd.bullet = bullet;
                bulletClone.AddComponent<BulletPhysics>();
                bulletClone.transform.position = bulletPoint.position;
                Vector3 bulletRotation = gunPos.eulerAngles;
                bulletRotation.z += Random.Range(gun.minDeviation, gun.maxDeviation);
                bulletClone.transform.eulerAngles = bulletRotation;
                bulletClone.transform.localScale = new Vector3(bullet.scaleX, bullet.scaleY, bullet.scaleZ);
                Rigidbody2D rb = bulletClone.AddComponent<Rigidbody2D>();
                rb.AddForce(bulletClone.transform.right * gun.bulletForce, ForceMode2D.Impulse);
                chargeTime = gun.chargeTime;
            }
            AudioManager.PlaySound("gunshot");
        }
    }
}
