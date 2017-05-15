using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    float f_currentSpeed;
    float f_maxSpeed;
    public float f_jumpValue;
    Animator anim;

    Rigidbody2D rigidbody;

    public bool isgrounded;

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
        f_jumpValue = 280.0f;

        maxHp = 100;
        currentHp = maxHp;
	}
	
	// Update is called once per frame
	void Update ()
    {
        isgrounded = Physics2D.IsTouchingLayers(myCollider, isGround);
        // 터치하면 점프
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetKeyDown(KeyCode.Space))
        {
            if(isgrounded)
            { 
                anim.SetTrigger("Jump");
                transform.Translate(Vector3.up * f_jumpValue * Time.deltaTime, Space.World);
                //rigidbody.velocity = new Vector2(rigidbody.velocity.x, f_jumpValue);
                //rigidbody.AddForce(transform.up * f_jumpValue, ForceMode2D.Impulse);
            }
        }
        currentHp -= Time.deltaTime * 3.0f;
        float perc = currentHp / maxHp;
        health.value = perc;

        Debug.Log(perc);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Collider2D>().gameObject.layer == LayerMask.NameToLayer("Potion"))
        {
            if (currentHp + 5 < maxHp)
                currentHp += 2;
            else
                currentHp = maxHp;
        }
        //else if (other.GetComponent<Collider2D>().gameObject.layer == LayerMask.NameToLayer("Coin"))

        Destroy(other.gameObject);
    }
}
