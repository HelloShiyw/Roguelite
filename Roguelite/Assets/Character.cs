using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Character", menuName ="Character")]
public class Character : ScriptableObject
{
    public string charName;
    public int maxHP;
    public float speed;
}
