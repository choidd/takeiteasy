using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBar : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") // gameover
        {
            Destroy(collision.gameObject);
            return;
        }

        if (collision.transform.parent)
            Destroy(collision.transform.parent.gameObject);
        else
            Destroy(collision.gameObject);
    }
}
