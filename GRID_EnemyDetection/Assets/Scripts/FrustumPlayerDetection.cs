using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrustumPlayerDetection : MonoBehaviour
{
	public GameObject player;
    public bool Detected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            //play sound so player knows alien is triggered

            Detected = true;
            Debug.Log("Stealth Mode Exited");

            //add shooting code
        }
    }

    /*void OnTriggerStay(Collider other)
	{
        if (other.gameObject == player)
        {
            Vector3 relPlayerPos = player.transform.position - transform.position;
            RaycastHit hit;

            if (Physics.Raycast(transform.position, relPlayerPos, out hit))
            {
                if (hit.collider.gameObject == player)
                {
                    Debug.Log("Player Detected: shoot?");
                }
            }
        }
	}*/
}
