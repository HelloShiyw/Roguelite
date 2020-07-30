using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet", menuName = "Bullet")]
public class Bullet : ScriptableObject
{
    public string sprite, shotType; //shot types may be spray and normal?
    public float scaleX, scaleY, scaleZ;
}
