using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float fallMult = 2.5f;
    public float lowerJumpMult = 1.8f;

    private Rigidbody2D _rigidbody2D;
    public void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_rigidbody2D.velocity.y < 0)
        {
            _rigidbody2D.velocity += Vector2.up * (Physics2D.gravity.y * (fallMult - 1) * Time.deltaTime);
        } else if (_rigidbody2D.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            _rigidbody2D.velocity += Vector2.up * (Physics2D.gravity.y * (lowerJumpMult - 1) * Time.deltaTime);
        }

    }
}
