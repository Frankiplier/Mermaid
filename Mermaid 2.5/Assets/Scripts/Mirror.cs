using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public bool canLook;
    [SerializeField] GameObject mirror;

    void Start()
    {
        canLook = false;

        mirror.SetActive(false);
    }

    void Update()
    {
        if (canLook == true && Input.GetKey(KeyCode.E))
        {
            mirror.SetActive(true);
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            canLook = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            canLook = false;
        }
    }
}
