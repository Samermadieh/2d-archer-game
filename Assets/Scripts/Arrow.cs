using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Arrow : MonoBehaviour
{

    Rigidbody2D rb;
    bool hasHit;
    public AudioSource hitSound;
    public Text numArrows;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hitSound = GetComponent<AudioSource>();
        numArrows = GameObject.Find("NumArrows").GetComponent<Text>();
    }

    void Update()
    {
        if(hasHit == false)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitSound.Play();
        hasHit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;

        if (collision.gameObject.tag.Equals("Bullseye"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(collision.gameObject.tag.Equals("Death"))
        {
            SceneManager.LoadScene("Lose");
        }
        else
        {
            if(Int32.Parse(numArrows.text) == 0)
            {
                SceneManager.LoadScene("Lose");
            }
        }
    }
}
