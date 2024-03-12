using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float jumpForce = 0.5f;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.simulated = false;
        Input.simulateMouseWithTouches = true;
    }
    
   void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_rb.simulated)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
            }
            else
            {
                _rb.simulated = true;
            }
        }
    }
}
