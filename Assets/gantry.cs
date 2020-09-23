using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gantry : MonoBehaviour
{
    [SerializeField]
    private GameObject crane;
    [SerializeField]
    private GameObject arm;


    private void OnTriggerStay(Collider player)
    {
        if (Input.GetKey(name: "i"))
        {
        crane.transform.position += new Vector3((float).05, 0, 0);
        }

        if (Input.GetKey(name: "k"))
        {
            crane.transform.position += new Vector3((float)-.05, 0, 0);
        }

        if (Input.GetKey(name: "j"))
        {
            arm.transform.position += new Vector3(0, 0, (float).05);
        }

        if (Input.GetKey(name: "l"))
        {
            arm.transform.position += new Vector3(0, 0, (float)-.05);
        }

    }
}