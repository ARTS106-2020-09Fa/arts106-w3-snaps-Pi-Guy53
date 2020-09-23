using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint_script : MonoBehaviour
{
[SerializeField]
    private GameObject Hint;
    
    private void OnTriggerEnter(Collider Player)
    {
        Hint.transform.position += new Vector3(0, 3, 0);
    }

    void OnTriggerExit(Collider Player)
    {
    Hint.transform.position += new Vector3(0, -3, 0);
    }
}
