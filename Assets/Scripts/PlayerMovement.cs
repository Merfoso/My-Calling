using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector2 movement;
    public SpriteRenderer spriteRenderer;
    public float rFloat;
    public float gFloat;
    public float bFloat;
    public ParticleSystem particles;
    public AudioSource clip;
    public DreamCounter dreams;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        particles = this.GetComponent<ParticleSystem>();
        particles.Stop();
        clip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PinkBall")
        {
            collision.gameObject.SetActive(false);
            dreams.dreamsConsumed++;
            ChangeColor();
            Debug.Log("choco");
            clip.Play();
        }

    }

    private void ChangeColor()
    {
        rFloat += 203f;
        gFloat += 212f;
        bFloat += 90f;

        spriteRenderer.color = new Color(rFloat, gFloat, bFloat);
    }
}
