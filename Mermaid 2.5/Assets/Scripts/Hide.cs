using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    [SerializeField] Basilisk basilisk;
    [SerializeField] PlayerMovement player;

    public bool canHide = false;
    public bool isHiding = false;
    
    void Start()
    {
        isHiding = false;
        canHide = false;
    }

    void Update()
    {
        if (canHide == true && basilisk.mustHide == true && Input.GetKey(KeyCode.E))
        {
            isHiding = true;
            player.moveSpeed = 0;
        }

        if (isHiding == false)
        {
            player.moveSpeed = 3;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Hiding")
        {
            canHide = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Hiding")
        {
            canHide = false;
        }
    }

}
