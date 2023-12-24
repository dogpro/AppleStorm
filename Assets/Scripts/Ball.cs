using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Rigidbody2D _ballBody;
    [SerializeField] private float _speedDown;
    [SerializeField] private float _speedMove;
    
    
    private Vector2 _velocity = Vector2.zero;
    
    public Color BallColor;

    public void SetColor(Color newColor)
    {
        BallColor = newColor;
        _spriteRenderer.color = newColor;
    }

    private void FixedUpdate()
    {
        _velocity.x = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _velocity.x = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _velocity.x = 1;
        }

        Vector2 vector2 = new(_velocity.x * _speedMove, _speedDown);
        _ballBody.velocity = vector2 * Time.fixedDeltaTime;
    }
}
