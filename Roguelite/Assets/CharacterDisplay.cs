using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDisplay : MonoBehaviour
{
    public Character character;
    public GameObject pickedGun;
    public Transform gunPoint;
    // Start is called before the first frame update
    void Start()
    {
        //character.pickedGun = pickedGun.GetComponent<GunDisplay>().gun.name;
    }


}
