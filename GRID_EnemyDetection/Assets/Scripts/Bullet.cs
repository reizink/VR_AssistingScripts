using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector3 target;
    public PlayerHealth healthScript;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        healthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

        target = new Vector3(player.position.x, player.position.y, player.position.z);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.z == target.z)
        {
            DestroyBullet();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DestroyBullet();

            healthScript.health -= 10;
            //particle explosions here
        }
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
        //particle explosions here
    }
}
