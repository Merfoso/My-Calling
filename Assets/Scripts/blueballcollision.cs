using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueballcollision : MonoBehaviour
{
    public ParticleSystem particles;
    public AudioSource clip;
    public DreamCounter dreams;
    void Start()
    {
        particles.Stop();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            particles.Play();
            this.gameObject.SetActive(false);
            dreams.dreamsConsumed++;
            clip.Play();
        }
    }
}
