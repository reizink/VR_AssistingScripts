using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //replace with a new trigger ****************
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            if(Physics.Raycast(ray, out hit))
            {
                //Debug.Log(hit.transform.name);
                if (hit.transform.name == transform.tag) //make sure button is tagged
                {
                    anim.Play("ButtonPress1");
                    //Debug.Log("Success");
                }
            }
        }
    }
}
