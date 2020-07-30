using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDisplay : MonoBehaviour
{
    public Gun gun;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.GetComponentInParent<CharacterDisplay>().pickedGun.GetComponent<GunDisplay>().gun.gunName.Equals(gun.gunName))
        {
            SpriteRenderer spriteRenderer = gameObject.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
            spriteRenderer.sprite = Resources.Load<SpriteRenderer>(gun.sprite).sprite;
        }
    }
}
