using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Gun : ScriptableObject
{
    public string gunName, sprite;
    public float holdRadius, bulletForce, scaleX, scaleY, scaleZ, damage, minDeviation, maxDeviation, chargeTime;
    public int shotAmount;
    public Bullet bullet;
}
