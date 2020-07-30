using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    //public AudioSource dashSound;
    public float speed = 5f;
    public float dashLength = 100f;
    public float dashSpeed = 20f;
    private int currDash = 0;
    private float dashHorizontal;
    private float dashVertical;
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 move = new Vector2();
        if (currDash == 0) {
            if (Input.GetButtonDown("Dash"))
            {
                dashHorizontal = horizontalInput;
                dashVertical = verticalInput;
                currDash = (int)Math.Floor(dashLength / dashSpeed);
                AudioManager.PlaySound("dash");
            } 
            else 
            {
               move = new Vector2(horizontalInput, verticalInput) * Time.deltaTime * speed;
            }
        }
        else
        {
            move = new Vector2(dashHorizontal, dashVertical) * Time.deltaTime * dashSpeed;
            currDash--;
        }
        transform.Translate(move);
    }
}
