using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{
    public AudioClip gameoverSound;
    public AudioSource audioSource;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(gameoverSound);
        }
    }
}
