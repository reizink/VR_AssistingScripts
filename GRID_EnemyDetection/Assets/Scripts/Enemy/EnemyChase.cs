using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject bullet; ///
    public Transform player;
    public FrustumPlayerDetection DetectScript;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        DetectScript = transform.GetComponentInChildren<FrustumPlayerDetection>();

        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if (DetectScript.Detected == false) {
            transform.position = this.transform.position; //stay in place
        }
        else if(Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.position.x, transform.position.y, player.position.z), speed * Time.deltaTime);
        } else if((Vector3.Distance(transform.position, player.position) < stoppingDistance) && (Vector3.Distance(transform.position, player.position) > retreatDistance))
        {
            transform.position = this.transform.position;
        } else if (Vector3.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.position.x, transform.position.y, player.position.z), -speed * Time.deltaTime);

            // player.position target ===>>> (player.position.x, transform.position.y, player.position.z)
        }

        if(timeBtwShots <= 0 && DetectScript.Detected == true)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }   
}
