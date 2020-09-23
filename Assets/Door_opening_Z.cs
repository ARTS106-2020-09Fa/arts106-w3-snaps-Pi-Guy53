using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_opening_Z : MonoBehaviour
{
    [SerializeField]
    GameObject Door;


    private void OnTriggerEnter(Collider Player)
    {

        Door.transform.position += new Vector3(0, 0, 1);
    }


    private void OnTriggerExit(Collider Player)
    {
        Door.transform.position += new Vector3(0, 0, -1);
    }
}