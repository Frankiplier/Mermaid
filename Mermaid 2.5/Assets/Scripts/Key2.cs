using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2 : MonoBehaviour
{
    [SerializeField] public KeyRoom2 keyRoom2;

    public bool isVisible = false;

    // Start is called before the first frame update
    void Start()
    {
        isVisible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVisible == true && Input.GetKey(KeyCode.E))
        {
            keyRoom2.haveKey2 = true;
            
            GetComponent<CapsuleCollider>().enabled = false;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            isVisible = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isVisible = false;
        }
    }
}
