using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public bool canPickUp = false;
    public bool canEnd = false;

    void Update()
    {
        if (canPickUp == true && Input.GetKeyDown(KeyCode.E))
        {
            canEnd = true;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            canPickUp = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            canPickUp = false;
        }
    }
}
