using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private bool isDead;
    public float jumpForce = 0.5f;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.simulated = false;
        Input.simulateMouseWithTouches = true;
    }
    
   void Update()
    {
        if (isDead)
        {
            return;
        }
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

   private void OnCollisionEnter2D(Collision2D other)
   {
       StartCoroutine(Co_OnDeath());
   }

   IEnumerator Co_OnDeath()
   {
       isDead = true;
       yield return new WaitForSeconds(3);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
   }
}
