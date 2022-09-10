using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;


public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float upSpeed = 17f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * upSpeed , ForceMode2D.Force);
        }
        //rb.AddForce(Vector2.right * 10 * Time.deltaTime, ForceMode2D.Force);
    }
}
