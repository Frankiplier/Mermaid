using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public bool canLook;
    public bool isActive = false;
    [SerializeField] GameObject mirror;

    void Start()
    {
        canLook = false;
        isActive = false;

        mirror.SetActive(false);
    }

    void Update()
    {
        if (canLook == true && isActive == false && Input.GetKeyDown(KeyCode.E))
        {
            mirror.SetActive(true);
            isActive = true;

            Cursor.visible = true; 
            Cursor.lockState = CursorLockMode.None;
        }

        else if (isActive == true && Input.GetKeyDown(KeyCode.E))
        {
            mirror.SetActive(false);
            isActive = false;

            Cursor.visible = false; 
            Cursor.lockState = CursorLockMode.Locked;
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
