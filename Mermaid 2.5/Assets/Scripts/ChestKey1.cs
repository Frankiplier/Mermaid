using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestKey1 : MonoBehaviour
{
    public GameObject key;
    public bool chestKey1 = false;
    public bool canBePickedUp = false;

    void Update()
    {
        if (canBePickedUp == true && Input.GetKeyDown(KeyCode.E))
        {
            chestKey1 = true;
            key.SetActive(false);
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            canBePickedUp = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            canBePickedUp = false;
        }
    }
}
