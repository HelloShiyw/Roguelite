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
    public string bullet; //maybe wont use
    public float damage; //yet to do anything cuz no enemies or hp
}
