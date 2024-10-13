using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestKey2 : MonoBehaviour
{
    public GameObject key;
    public bool chestKey2 = false;
    public bool canBePickedUp = false;

    void Update()
    {
        if (canBePickedUp == true && Input.GetKeyDown(KeyCode.E))
        {
            chestKey2 = true;
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
