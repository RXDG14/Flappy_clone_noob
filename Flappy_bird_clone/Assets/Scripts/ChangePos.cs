using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangePos : MonoBehaviour
{
    Rigidbody2D rb;

    float speed = 100f;
    float pos = -12f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        UpdatePos();
    }

    void UpdatePos()
    {
        var currentPos = transform.position;
        var newPos = new Vector2(12, Random.Range(4,9));
        if (currentPos.x < pos)
        {
            transform.position = newPos;
        }
        //rb.AddForce(Vector2.left * speed * Time.deltaTime);
        rb.velocity = Vector2.left * speed * Time.deltaTime;
    }
}
