using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rb;
    public Collider2D collider;
    SpriteRenderer sr;
    public float force = 200;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        if (rb.OverlapPoint(new Vector2(3, 0)))
        {
            sr.color = Color.green;
        }
        else
        {
            sr.color = Color.white;
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(direction * force * Time.deltaTime);
    }
}
