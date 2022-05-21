using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dreamcollision : MonoBehaviour
{
    public AudioSource clip;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            this.gameObject.SetActive(false);
            clip.Play();
        }
    }

}
