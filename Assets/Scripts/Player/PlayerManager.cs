using System.Collections;
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

    public float currentHp;
    float maxHp;

    // hp
    UIProgressBar health;

    // Use this for initialization
    void Start ()
    {
        health = GameObject.Find("BG_Healthbar").GetComponent<UIProgressBar>();
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
                rigidbody.AddForce(transform.up * f_jumpValue, ForceMode2D.Force);
            }
        }
        currentHp -= Time.deltaTime * 0.001f;
        float perc = 100 - currentHp / maxHp * 100;
        health.value -= perc;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Collider2D>().gameObject.layer == LayerMask.NameToLayer("Item"))
        {
            if (currentHp + 5 < maxHp)
                currentHp += 5;
            else
                currentHp = maxHp;

            Destroy(other.gameObject);
        }
    }
}
