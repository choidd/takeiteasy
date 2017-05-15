﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    float f_currentSpeed;
    float f_maxSpeed;
    public float f_jumpValue;
    Animator anim;

    Rigidbody2D rigidbody;

    public bool grounded;

    public LayerMask isGround;

    Collider2D myCollider;

    int currentHp;
    int maxHp;
	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        anim = GetComponentInChildren<Animator>();
        f_currentSpeed = 5.0f;
        f_maxSpeed = 5.0f;
        f_jumpValue = 15.0f;

        maxHp = 100;
        currentHp = maxHp;
	}
	
	// Update is called once per frame
	void Update ()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, isGround);
        // 터치하면 점프
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetKeyDown(KeyCode.Space))
        {
            if(grounded)
            { 
                anim.SetTrigger("Jump");
                //rigidbody.velocity = new Vector2(rigidbody.velocity.x, f_jumpValue);
                rigidbody.AddForce(transform.up * f_jumpValue);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Collider2D>().gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}