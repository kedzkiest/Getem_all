using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent enemy;
    public GameObject target;

    public AudioClip gameoverSound;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        enemy = gameObject.GetComponent<NavMeshAgent>();
        enemy.speed = 5;
        enemy.acceleration = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            enemy.destination = target.transform.position;
        }

        int point = PlayerController.checkGetPoint();
        enemy.speed = 5 + point / 1.5f;
        enemy.acceleration = 5 + point / 1.5f;

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(gameoverSound);
        }
    }
}
