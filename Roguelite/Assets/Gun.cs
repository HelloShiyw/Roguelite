using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Gun : ScriptableObject
{
    public string gunName;
    public float holdRadius;
    public float bulletForce;
    public string sprite;
    public Bullet bullet;
    public float damage; //yet to do anything cuz no enemies or hp
}
