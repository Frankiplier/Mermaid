using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public bool isHiding = false;
    
    void Start()
    {
        isHiding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            isHiding = true;
        }

        else
        {
            isHiding = false;
        }
    }
}
